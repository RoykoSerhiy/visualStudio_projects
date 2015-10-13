using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace SocketChat
{
    class ChatListener
    {
        Socket _listener = null;

        byte[] buffer = new byte[1024];
        IPEndPoint _ipEndPoint;

        public IPEndPoint IPEndPoint
        {
            get { return _ipEndPoint; }
        }

        public delegate void MessageReceivedDelegate(string message);
        public event MessageReceivedDelegate MessageReceived;

        public ChatListener(string ipAddress = "127.0.0.1", int port = 7000)
        {
            _ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
        }

        public void Start()
        {
            _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                _listener.Bind(_ipEndPoint);
                _listener.Listen(10);

                _listener.BeginAccept(new AsyncCallback(OnAccept), _listener);
            }
            catch (Exception ex)
            {
                int t = 2;
            }
        }

        public void Close()
        {
            _listener.Shutdown(SocketShutdown.Both);
            _listener.Close();
        }

        private void OnAccept(IAsyncResult ia)
        {
            try
            {
                Socket clientSocket = _listener.EndAccept(ia);
                _listener.BeginAccept(new AsyncCallback(OnAccept), _listener);

                //Once the client connects then start 
                //receiving the commands from her
                clientSocket.BeginReceive(buffer, 0,
                    buffer.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), clientSocket);
            }
            catch (Exception ex)
            {

            }
        }

        private void OnReceive(IAsyncResult ia)
        {
            try
            {
                Socket clientSocket = (Socket)ia.AsyncState;
                clientSocket.EndReceive(ia);

                string message = Encoding.UTF8.GetString(buffer);

                if (MessageReceived != null)
                    MessageReceived(message);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
