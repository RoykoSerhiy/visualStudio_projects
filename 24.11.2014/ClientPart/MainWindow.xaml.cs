using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace ClientPart
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPHostEntry ipHost;
        IPAddress ipAddr;

        IPEndPoint ipEndPoint;
        Socket sender_1;
        byte[] bytes;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            ipHost = Dns.GetHostEntry("localhost");
            ipAddr = ipHost.AddressList[0];

            ipEndPoint = new IPEndPoint(ipAddr, Convert.ToInt32(tbxPort.Text));
            sender_1 = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            bytes = new byte[1024];
            sender_1.Connect(ipEndPoint);
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSend_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
               
                SendMessageFromSocket(11000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }

        }
        public void SendMessageFromSocket(int port)
        {
            
           
           
            string message = tbxMessage.Text;

            lblStatus.Content = "Сокет соединяется с " + sender_1.RemoteEndPoint.ToString();
            byte[] msg = Encoding.UTF8.GetBytes(message);

            int bytesSent = sender_1.Send(msg);
            
            int bytesRec = sender_1.Receive(bytes);
            tbxMessage.Text = "\nОтвет от сервера: " + Encoding.UTF8.GetString(bytes, 0, bytesRec);
           
           
            
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            sender_1.Shutdown(SocketShutdown.Both);
            sender_1.Close();
            this.Close();
        }

       
    }
}
