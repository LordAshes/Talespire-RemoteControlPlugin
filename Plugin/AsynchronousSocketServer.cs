using BepInEx;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
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

        private static Action<Socket, string> _callback = null;

        private static bool _diagnostics = false;

        public static class AsynchronousSocketListener
        {
            static Socket listener = null;

            public static void StartListening(int port, Action<Socket,string> callback, bool diagnostics = false)
            {
                _diagnostics = diagnostics;

                _callback = callback;

                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);

                // Create a TCP/IP socket.
                if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Creating Socket"); }
                listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Bind the socket to the local endpoint and listen for incoming connections.  
                try
                {
                    if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Binding To End Point"); }
                    listener.Bind(localEndPoint);
                    listener.Listen(100);

                    // Start an asynchronous socket to listen for connections.  
                    if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Accept"); }
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                }
                catch (Exception e)
                {
                    Debug.LogWarning(e);
                }
            }

            public static void AcceptCallback(IAsyncResult ar)
            {
                // Get the socket that handles the client request.  
                if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Accept Callback"); }
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = handler;
                if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Begin Data Read"); }
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
            }

            public static void ReadCallback(IAsyncResult ar)
            {
                String content = String.Empty;

                // Retrieve the state object and the handler socket  
                // from the asynchronous state object.  
                if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Get Read State"); }
                StateObject state = (StateObject)ar.AsyncState;
                Socket handler = state.workSocket;

                // Read data from the client socket.
                if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Get Bytes"); }
                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Append Bytes To Message"); }
                    // There  might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Check for end-of-file tag. If it is not there, read more data.  
                    content = state.sb.ToString();
                    if (content.IndexOf("\n") > -1)
                    {
                        if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Reading Line Complete"); }
                        _callback(handler, content);
                        AsynchronousSocketListener.Send(handler, content);
                    }
                    else
                    {
                        // Not all data received. Get more.  
                        if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Reading Line Incomplete"); }
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                    }
                }
            }

            public static void Send(Socket handler, String data)
            {
                // Convert the string data to byte data using ASCII encoding.  
                byte[] byteData = Encoding.ASCII.GetBytes(data);

                // Begin sending the data to the remote device.  
                if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Send Begin"); }
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.  
                    if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Send Data"); }
                    Socket handler = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.  
                    int bytesSent = handler.EndSend(ar);

                    if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Close Connection"); }
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                    handler.Dispose();

                    if (_diagnostics) { Debug.Log("Remote Control Plugin: Server: Wait For New Connection"); }
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                }
                catch (Exception e)
                {
                    Debug.LogWarning(e);
                }
            }
        }
    }
}