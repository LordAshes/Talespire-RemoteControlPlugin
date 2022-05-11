using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPSend
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse(args[0]);
            int port = int.Parse(args[1]);
            string message = String.Join(" ", args.Skip(2));

            Console.WriteLine("Using IP: " + ip);
            Console.WriteLine("Using Port: " + port);
            Console.WriteLine("Using Message: " + message);

            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(ip,port);

                Socket client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                client.Connect(remoteEndPoint);
                client.Send(Encoding.ASCII.GetBytes(message+"\r\n"));

                client.Close();
                client.Dispose();
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception: " + x);
            }
        }
    }
}
