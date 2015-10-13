using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace SocketChat
{
    public partial class MainForm : Form
    {
        string _titlePattern = "The Best Chat [{0}]";

        ChatListener _chListener;
        IPEndPoint _remoteEndPoint;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format(_titlePattern, "Not connected");
            this.rtbChat.ReadOnly = true;
            if (tbMessage.CanFocus)
                tbMessage.Focus();
        }

        private async void btnCreteListener_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLocalIPAddress.Text))
            {
                MessageBox.Show("Please enter IP address for listener!");
                return;
            }

            int port = 7000;
            int.TryParse(tbLocalPort.Text, out port);

            _chListener = new ChatListener(tbLocalIPAddress.Text, port);
            _chListener.MessageReceived += MessageRecieved;
            _chListener.Start();

            this.Text = String.Format(_titlePattern, _chListener.IPEndPoint.ToString());
        }

        private async void btnRemoteSet_Click(object sender, EventArgs e)
        {
            _remoteEndPoint = new IPEndPoint(IPAddress.Parse(tbRemoteIP.Text), int.Parse(tbRemotePort.Text));
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (_chListener == null)
            {
                MessageBox.Show("Please, create listener!");
                return;
            }

            if (_remoteEndPoint == null)
            {
                MessageBox.Show("Please, set remote endpoint!");
                return;
            }

            string msg = tbMessage.Text;
            if (string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("Please, enter message!");
                return;
            }

            rtbChat.AppendText(String.Format("[{0}] {1}: ", DateTime.Now.ToString("HH:mm:ss"), tbUserName.Text));
            rtbChat.AppendText(msg, Color.Red);
            rtbChat.AppendText(Environment.NewLine);

            msg = String.Format("[{0}] {1}: {2}", DateTime.Now.ToString("HH:mm:ss"), tbUserName.Text, msg);

            ChatSender.Send(_remoteEndPoint.Address.ToString(), _remoteEndPoint.Port, msg);
            tbMessage.Text = "";
        }

        private void tbMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSend_Click(sender, e);
        }

        private void MessageRecieved(string msg)
        {
            rtbChat.BeginInvoke(new AddTextDelegate(AddMsg), msg);
        }

        delegate void AddTextDelegate(string msg);
        private void AddMsg(string msg)
        {
            rtbChat.AppendText(msg);
            rtbChat.AppendText(Environment.NewLine);
        }
    }
	
	public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
