using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
using System.Xml.Serialization;

namespace ClientDouble2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        [Serializable]
        public class FileDetails
        {
            public string FileType = "";
            public long FileSize = 0;

            public string FILETYPE { get; set; }
            public long FILESIZE { get; set; }
        }

        private static FileDetails fileDet;
        //public static string Status = null;
        private static int Port = 7000;
        private static UdpClient udpClient = new UdpClient(Port);
        private static IPEndPoint IpEndPoint = null;

        private static FileStream fs;
        private static Byte[] receiveBytes = new Byte[0];

        

        public void GetFileDetails()
        {
            try
            {
                tbxStatus.Text += "Wait resive file details\n";
                receiveBytes = udpClient.Receive(ref IpEndPoint);
                string s = "recived bytes: ";
                foreach (byte b in receiveBytes)
                {
                    s += b + ",";
                }
                MessageBox.Show(s);
                tbxStatus.Text += "file details resived\n";

                XmlSerializer fileSerializer = new XmlSerializer(typeof(FileDetails));
                MemoryStream stream1 = new MemoryStream();

                stream1.Write(receiveBytes, 0, receiveBytes.Length);
                stream1.Position = 0;

                fileDet = (FileDetails)fileSerializer.Deserialize(stream1);

                tbxStatus.Text += "Recived file type ." + fileDet.FILETYPE +
                    " file size " + fileDet.FILESIZE.ToString() + " bytes\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " GetFileDetails()");

            }

        }

        public void ReciveFile()
        {
            try
            {
                tbxStatus.Text += "Wait to recive file\n";
                receiveBytes = udpClient.Receive(ref IpEndPoint);

                tbxStatus.Text += "File recived ... Save\n";
                fs = new FileStream(@"C:\Users\Serhiy\Desktop\temp." + fileDet.FILETYPE, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                fs.Write(receiveBytes, 0, receiveBytes.Length);

                tbxStatus.Text += "File is Saved\n";
                Thread.Sleep(2000);
                tbxStatus.Text += "File Opened\n";

                Process.Start(fs.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Recive File");
            }
            finally
            {
                fs.Close();
                udpClient.Close();
                MessageBox.Show("ReciveFile finally");
                
            }
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            GetFileDetails();
            ReciveFile();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            fs.Close();
            udpClient.Close();
        }
    }
}
