using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatUdpExampleTest
{
    public partial class Form1 : Form
    {
        Socket sckCommunication;
        EndPoint epLocal, epRemote;
        bool isStarted = false;
        
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            sckCommunication = new Socket(AddressFamily.InterNetwork,
                                SocketType.Dgram, ProtocolType.Udp);
            sckCommunication.SetSocketOption(SocketOptionLevel.Socket,
                                SocketOptionName.ReuseAddress, true);

           
            txtYourIP.Text = GetLocalIP();
            txtFriendIP.Text = GetLocalIP();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
                                   
            epLocal = new IPEndPoint(IPAddress.Parse(txtYourIP.Text),
                                    Convert.ToInt32(txtYourPort.Text));
            sckCommunication.Bind(epLocal);

            
            epRemote = new IPEndPoint(IPAddress.Parse(txtFriendIP.Text),
                                    Convert.ToInt32(txtFriendPort.Text));
            sckCommunication.Connect(epRemote);

            buffer = new byte[1464];
            sckCommunication.BeginReceiveFrom(buffer, 0, buffer.Length,
                                     SocketFlags.None, ref epRemote,
                            new AsyncCallback(OperatorCallBack), buffer);

            
            isStarted = true;
        }
        private void OperatorCallBack(IAsyncResult ar)
        {
            try
            {
                int size = sckCommunication.EndReceiveFrom(ar, ref epRemote);

                // check if theres actually information
                if (size > 0)
                {
                    // used to help us on getting the data
                    byte[] aux = new byte[1464];

                    // gets the data
                    aux = (byte[])ar.AsyncState;

                    // converts from data[] to string
                    System.Text.ASCIIEncoding enc =
                                            new System.Text.ASCIIEncoding();
                    string msg = enc.GetString(aux);

                    // adds to listbox
                    listBox1.Items.Add("["+DateTime.Now.ToString()+"]" + txtNick.Text +":"+ msg);
                }

                // starts to listen again
                buffer = new byte[1464];
                sckCommunication.BeginReceiveFrom(buffer, 0,
                                    buffer.Length, SocketFlags.None,
                    ref epRemote, new AsyncCallback(OperatorCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isStarted == false)
            {
                btnStart_Click(sender , e);
            }
            
            System.Text.ASCIIEncoding enc =
                    new System.Text.ASCIIEncoding();
            byte[] msg = new byte[1024];
            msg = enc.GetBytes(txtMessage.Text);

            
            sckCommunication.Send(msg);

         
            listBox1.Items.Add("["+DateTime.Now.ToString()+"]" + txtNick.Text +": "  + txtMessage.Text);

            
            txtMessage.Clear();
        }
    }
}
