using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace SocketChat
{
    class ChatSender
    {
        public static void Send(string ip, int port, string message)
        {
            try
            {
                var ipAddress = IPAddress.Parse(ip);
                var ipEndPoint = new IPEndPoint(ipAddress, port);

                Socket Connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Connector.Connect(ipEndPoint);
                Byte[] SendBytes = Encoding.Default.GetBytes(message);
                Connector.Send(SendBytes);
                Connector.Close();
            }
            catch (Exception ex)
            {
                int t = 2;
            }
        }
    }
}
