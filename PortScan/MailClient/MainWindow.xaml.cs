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
using System.Net.Mail;

namespace MailClient
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

        private void btnSend_Click_1(object sender, RoutedEventArgs e)
        {

            SmtpClient client = new SmtpClient("smtp:gmail.com", 587);
            NetworkCredential crd = new NetworkCredential(tbxLogin.Text, tbxPassword.Text);
            client.Credentials = crd;
            client.EnableSsl = true;
            try
            {
                MailMessage msg = new MailMessage("SerhiyRoiiko96@gmail.com", "festivall.pr@gmail.com");
                msg.Body = tbxMessage.Text;
                client.Send(msg);
                MessageBox.Show("Seneded");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
