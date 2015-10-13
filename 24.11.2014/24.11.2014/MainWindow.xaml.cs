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

namespace _24._11._2014
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri myUri = new Uri("https://ru.wikipedia.org/wiki/URI");
                //WebClient webClient = new WebClient();
                //lblPoort.Content = "Port: " + myUri.Port + " Host: " + myUri.Host + " Local Path: " + myUri.LocalPath + " fileName ";
                //lblOther.Content = myUri.GetHashCode();
                //tbxContenet.Text = webClient.DownloadString("https://ru.wikipedia.org/wiki/URI");
                //webResponce
              // WebRequest webRequest = WebRequest.Create("https://ru.wikipedia.org/wiki/URI");
              // WebResponse webResponce = webRequest.GetResponse();
              // 
              // 
              // 
              // Stream dataStream = webResponce.GetResponseStream();
              // StreamReader reader = new StreamReader(dataStream);
              // string responseFromServer = reader.ReadToEnd();
              // tbxContenet.Text = responseFromServer;
              // 
              // 
              // 
              // WebHeaderCollection coll = webResponce.Headers;
              // string[] arrKeys = coll.AllKeys;
              // string[] arrValues = null;
              // //int count = 0;
              // for (int i = 0; i < arrKeys.Length; ++i)
              // {
              //     arrValues = coll.GetValues(i);
              // }
              // foreach (string c in arrKeys)
              // {
              // 
              //  
              //         lblPoort.Content += c + "\n";
              //    
              // }
              //MessageBox.Show("arrKeys Lenth: " + arrKeys.Length + " arrVal: " + arrValues.Length);
              //
              //lblRequest.Content = "Content Lenth: " + webResponce.ContentLength + "\n Type " + webResponce.ContentType
              //    + "\n Responce Uri: " + webResponce.ResponseUri + " \n Suports Headers: " + webResponce.SupportsHeaders
              //    + "\n is from chace: " + webResponce.IsFromCache
              //    + "\n Is Mutually Authenticated: " + webResponce.IsMutuallyAuthenticated;
              //
              //reader.Close();
              //dataStream.Close();
              //webResponce.Close();
                 
                //IPAdress


                //IPAddress[] ip = Dns.GetHostEntry("www.youtube.com").AddressList;
                //IPAddress obj = IPAddress.Parse(/*"173.194.71.91"*/ip[0].ToString());
                ////MessageBox.Show(ip[0].ToString());
                //IPHostEntry dns = Dns.GetHostEntry(obj);
                //
                //IPAddress[] address = dns.AddressList;
                //String[] alias = dns.Aliases;
                //
                //
                //
                //tbxContenet.Text += "Host Name: " + dns.HostName + "\n";
                //
                //tbxContenet.Text += "IPAdresses:\n";
                //for (int index = 0; index < address.Length; index++)
                //{
                //    tbxContenet.Text += address[index] + "\n";
                //}
                //tbxContenet.Text += "Aliases:\n";
                //for (int index = 0; index < alias.Length; index++)
                //{
                //    tbxContenet.Text += alias[index] + "\n";
                //}

               // Async();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        async void Async()
        {
            WebRequest webRequest = WebRequest.Create("https://ru.wikipedia.org/wiki/URI");
            webRequest.Proxy = null;
            WebResponse webResponce = await webRequest.GetResponseAsync();


            Stream dataStream = webResponce.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            tbxContenet.Text = responseFromServer;



            WebHeaderCollection coll = webResponce.Headers;
            string[] arrKeys = coll.AllKeys;
            string[] arrValues = null;
            //int count = 0;
            for (int i = 0; i < arrKeys.Length; ++i)
            {
                arrValues = coll.GetValues(i);
            }
            foreach (string c in arrKeys)
            {


                lblPoort.Content += c + "\n";

            }
            MessageBox.Show("arrKeys Lenth: " + arrKeys.Length + " arrVal: " + arrValues.Length);

            lblRequest.Content = "Content Lenth: " + webResponce.ContentLength + "\n Type " + webResponce.ContentType
                + "\n Responce Uri: " + webResponce.ResponseUri + " \n Suports Headers: " + webResponce.SupportsHeaders
                + "\n is from chace: " + webResponce.IsFromCache
                + "\n Is Mutually Authenticated: " + webResponce.IsMutuallyAuthenticated;

            reader.Close();
            dataStream.Close();
            webResponce.Close();
        }
    }
}
