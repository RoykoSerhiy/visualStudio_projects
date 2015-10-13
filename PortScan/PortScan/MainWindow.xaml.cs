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

namespace PortScan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int val = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                TimerCallback tcb = update;
                Timer t = new Timer(tcb);

                
                if (start())
                {
                    t.Dispose();
                }
                else
                {
                    t.Change(0, 100);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool start()
        {
            try
            {
                prgStatus.Maximum = Convert.ToInt32(tbxPortStart.Text) - Convert.ToInt32(tbxPortEnd.Text) + 1;
                prgStatus.Value = val;
                for (int CurrPort = Convert.ToInt32(tbxPortStart.Text); CurrPort <= Convert.ToInt32(tbxPortEnd.Text); CurrPort++)
                {
                    TcpClient TcpScan = new TcpClient();
                    try
                    {
                        TcpScan.Connect(tbxHost.Text, CurrPort);
                        tbxRes.Text += "Port " + CurrPort + " open\r\n";
                        tbxOpenPorts.Text += "Port " + CurrPort + " open\r\n";

                    }
                    catch
                    {
                        tbxRes.Text += "Port " + CurrPort + " closed\r\n";
                        
                    }

                    val += 1;
                    TcpScan.Close();
                    
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void update(object o)
        {
            prgStatus.Value = val;
        }

    }
}
