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
using System.IO;

namespace WpfApplication1
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

        private void btnDownload_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient client = new WebClient();

               
                NetworkCredential ntw_crd = new NetworkCredential(tbxLogin.Text, tbxPassword.Text);

                client.BaseAddress = tbxAddress.Text;
                client.Credentials = ntw_crd;
                client.DownloadFile(tbxAddress.Text, tbxFileName.Text);
                MessageBox.Show("Downloaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnUpload_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient client = new WebClient();

                string path = tbxPath.Text;
                string nameInServer = tbxNameInServer.Text;
                NetworkCredential ntw_crd = new NetworkCredential(tbxLogin.Text, tbxPassword.Text);

                client.BaseAddress = "ftp://bambaramia.esy.es";
                client.Credentials = ntw_crd;
                client.UploadFile(nameInServer, path);
                MessageBox.Show("Uploaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            try
            {
               
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://bambaramia.esy.es/");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                
                
                request.Credentials = new NetworkCredential("u232536431", "123456789");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                MessageBox.Show(reader.ReadToEnd());
                
               
                reader.Close();
                response.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
