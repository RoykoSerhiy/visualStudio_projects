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
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace portScanSocket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ManualResetEvent connectDone = new ManualResetEvent(false);

        public MainWindow()
        {
            InitializeComponent();
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket SockClient = (Socket)ar.AsyncState;
                SockClient.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Scan()
        {
            int StartPort = Convert.ToInt32(tbxPortStart.Text);
            int EndPort = Convert.ToInt32(tbxPortEnd.Text);
            int i;

            prgStatus.Maximum = EndPort - StartPort + 1;
            prgStatus.Value = 0;

            IPAddress IpAddr = null;
            try
            {
                IpAddr = IPAddress.Parse(tbxHost.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            for (i = StartPort; i <= EndPort; i++)
            {
                
                IPEndPoint IpEndP = new IPEndPoint(IpAddr, i);
                Socket MySoc = new Socket(AddressFamily.InterNetwork,
                                         SocketType.Stream, ProtocolType.Tcp);
               
                IAsyncResult asyncResult = MySoc.BeginConnect(IpEndP,
                                 new AsyncCallback(ConnectCallback), MySoc);


                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    MySoc.Close();
                    tbxRes.Text += "Порт " + i.ToString() + "закрыт\n";
                    prgStatus.Value += 1;
                }
                else
                {
                    MySoc.Close();
                    tbxRes.Text += "Порт " + i.ToString() + "открыт\n";
                    tbxOpenPorts.Text += "Порт " + i.ToString() + "открыт\n";
                    
                    prgStatus.Value += 1;
                }
             
            }

            prgStatus.Value = 0;
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            Scan();
        }        
    }
}
