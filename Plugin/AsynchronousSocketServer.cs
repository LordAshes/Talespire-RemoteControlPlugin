﻿using BepInEx;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

namespace LordAshes
{
    public partial class RemoteControlPlugin : BaseUnityPlugin
    {
        // State object for reading client data asynchronously  
        public class StateObject
        {
            // Size of receive buffer.  
            public const int BufferSize = 1024;

            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];

            // Received data string.
            public StringBuilder sb = new StringBuilder();

            // Client socket.
            public Socket workSocket = null;
        }

        public static class AsynchronousSocketListener
        {
            static Socket listener = null;

            public static void StartListening(int port)
            {
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);

                // Create a TCP/IP socket.  
                listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Bind the socket to the local endpoint and listen for incoming connections.  
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(100);

                    // Start an asynchronous socket to listen for connections.  
                    Console.WriteLine("Remote Control Plugin: Waiting for an instruction");
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            public static void AcceptCallback(IAsyncResult ar)
            {
                // Get the socket that handles the client request.  
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = handler;
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
            }

            public static void ReadCallback(IAsyncResult ar)
            {
                String content = String.Empty;

                // Retrieve the state object and the handler socket  
                // from the asynchronous state object.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket handler = state.workSocket;

                // Read data from the client socket.
                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There  might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Check for end-of-file tag. If it is not there, read more data.  
                    content = state.sb.ToString();
                    if (content.IndexOf("\n") > -1)
                    {
                        MessageHandler(handler, content);
                    }
                    else
                    {
                        // Not all data received. Get more.  
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                    }
                }
            }

            private static void Send(Socket handler, String data)
            {
                // Convert the string data to byte data using ASCII encoding.  
                byte[] byteData = Encoding.ASCII.GetBytes(data);

                // Begin sending the data to the remote device.  
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.  
                    Socket handler = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.  
                    int bytesSent = handler.EndSend(ar);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                    handler.Dispose();

                    Console.WriteLine("Remote Control Plugin: Waiting for an instruction");
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            private static void MessageHandler(Socket sender, string content)
            {
                Send(sender, content);
                content = content.Replace("\r\n", "\n");
                content = content.Replace("\r", "\n");
                content = content.Substring(0, content.IndexOf("\n"));
                Debug.Log("Remote Control Plugin: Request = " + content);

                string[] command = content.Split(',');
                CreatureBoardAsset asset = null;
                foreach (CreatureBoardAsset check in CreaturePresenter.AllCreatureAssets)
                {
                    if((check.Creature.Name+"<>").Substring(0,(check.Creature.Name + "<>").IndexOf("<")) == command[0]) { asset = check; break; }
                }
                if(asset!=null)
                {
                    switch(command[1])
                    {
                        case "Up":
                            asset.transform.position = new Vector3(asset.transform.position.x, asset.transform.position.y, asset.transform.position.z + 1);
                            break;
                        case "Down":
                            asset.transform.position = new Vector3(asset.transform.position.x, asset.transform.position.y, asset.transform.position.z - 1);
                            break;
                        case "Left":
                            asset.transform.position = new Vector3(asset.transform.position.x - 1, asset.transform.position.y, asset.transform.position.z);
                            break;
                        case "Right":
                            asset.transform.position = new Vector3(asset.transform.position.x + 1, asset.transform.position.y, asset.transform.position.z);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Remote Control Plugin: Asset Named '"+command[0]+"' Not Found.");
                }
            }
        }
    }
}