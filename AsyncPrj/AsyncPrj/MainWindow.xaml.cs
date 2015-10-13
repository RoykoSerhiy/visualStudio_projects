using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace AsyncPrj
{
    
    public partial class MainWindow : Window
    {

        public static string mainStr = null;
        public static string Message = null; 

        public MainWindow()
        {
            
            
            InitializeComponent();
            Message = tbxMessage.Text;
        }

       

       

        public class StateObject
        {

            public Socket workSocket = null;
            public const int BufferSize = 256;
            public byte[] buffer = new byte[BufferSize];
            public StringBuilder sb = new StringBuilder();
            

        }

        public class AsynchronousClient
        {
            private const int port = 11000;

            private ManualResetEvent connectDone =
                new ManualResetEvent(false);
            private ManualResetEvent sendDone =
                new ManualResetEvent(false);
            private ManualResetEvent receiveDone =
                new ManualResetEvent(false);

            private String response = String.Empty;
            

            public void StartClient()
            {
                try
                {
                    IPHostEntry ipHostInfo = Dns.GetHostEntry("localhost");
                    IPAddress ipAddress = ipHostInfo.AddressList[0];
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                    Socket client = new Socket(ipAddress.AddressFamily,
                        SocketType.Stream, ProtocolType.Tcp);

                    client.BeginConnect(remoteEP,
                        new AsyncCallback(ConnectCallback), client);
                    connectDone.WaitOne();

                    Send(client, Message);
                    sendDone.WaitOne();

                    Receive(client);
                    receiveDone.WaitOne();

                    mainStr += "Response received : " + response + "\n";

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            private void ConnectCallback(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState;

                    client.EndConnect(ar);

                    mainStr += "Socket connected to " + 
                        client.RemoteEndPoint.ToString() + "\n";

                    connectDone.Set();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            private void Receive(Socket client)
            {
                try
                {
                    StateObject state = new StateObject();
                    state.workSocket = client;

                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            private void ReceiveCallback(IAsyncResult ar)
            {
                try
                {
                    StateObject state = (StateObject)ar.AsyncState;
                    Socket client = state.workSocket;

                    int bytesRead = client.EndReceive(ar);

                    if (bytesRead > 0)
                    {
                        state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                        client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(ReceiveCallback), state);
                    }
                    else
                    {
                        if (state.sb.Length > 1)
                        {
                            response = state.sb.ToString();
                        }
                        receiveDone.Set();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            private void Send(Socket client, String data)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(data);

              
                client.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), client);
            }

            private void SendCallback(IAsyncResult ar)
            {
                try
                {
                   
                    Socket client = (Socket)ar.AsyncState;

                   
                    int bytesSent = client.EndSend(ar);
                    mainStr += "Sent {0} bytes to server " + bytesSent + "\n";

                   
                    sendDone.Set();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }

        private void btnSend_Click_1(object sender, RoutedEventArgs e)
        {
            AsynchronousClient c = new AsynchronousClient();
            c.StartClient();
            tbxMessage.Text = mainStr;
               
        }


    }
}
