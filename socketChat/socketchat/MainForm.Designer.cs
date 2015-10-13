namespace SocketChat
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRemoteIPAddress = new System.Windows.Forms.Label();
            this.tbRemoteIP = new System.Windows.Forms.TextBox();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnRemoteSet = new System.Windows.Forms.Button();
            this.gbRemote = new System.Windows.Forms.GroupBox();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.tbLocalIPAddress = new System.Windows.Forms.TextBox();
            this.lblLocalIPAddress = new System.Windows.Forms.Label();
            this.btnCreteListener = new System.Windows.Forms.Button();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.lblLocalPort = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.gbRemote.SuspendLayout();
            this.gbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemoteIPAddress
            // 
            this.lblRemoteIPAddress.AutoSize = true;
            this.lblRemoteIPAddress.Location = new System.Drawing.Point(12, 18);
            this.lblRemoteIPAddress.Name = "lblRemoteIPAddress";
            this.lblRemoteIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblRemoteIPAddress.TabIndex = 0;
            this.lblRemoteIPAddress.Text = "IP Address:";
            // 
            // tbRemoteIP
            // 
            this.tbRemoteIP.Location = new System.Drawing.Point(15, 35);
            this.tbRemoteIP.Name = "tbRemoteIP";
            this.tbRemoteIP.Size = new System.Drawing.Size(100, 20);
            this.tbRemoteIP.TabIndex = 1;
            this.tbRemoteIP.Text = "127.0.0.1";
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.Location = new System.Drawing.Point(121, 35);
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(47, 20);
            this.tbRemotePort.TabIndex = 3;
            this.tbRemotePort.Text = "7000";
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(118, 18);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(29, 13);
            this.lblRemotePort.TabIndex = 2;
            this.lblRemotePort.Text = "Port:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(13, 391);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(351, 20);
            this.tbMessage.TabIndex = 5;
            this.tbMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMessage_KeyPress);
            // 
            // btnRemoteSet
            // 
            this.btnRemoteSet.Location = new System.Drawing.Point(93, 63);
            this.btnRemoteSet.Name = "btnRemoteSet";
            this.btnRemoteSet.Size = new System.Drawing.Size(75, 23);
            this.btnRemoteSet.TabIndex = 6;
            this.btnRemoteSet.Text = "Set";
            this.btnRemoteSet.UseVisualStyleBackColor = true;
            this.btnRemoteSet.Click += new System.EventHandler(this.btnRemoteSet_Click);
            // 
            // gbRemote
            // 
            this.gbRemote.Controls.Add(this.tbRemoteIP);
            this.gbRemote.Controls.Add(this.btnRemoteSet);
            this.gbRemote.Controls.Add(this.lblRemoteIPAddress);
            this.gbRemote.Controls.Add(this.tbRemotePort);
            this.gbRemote.Controls.Add(this.lblRemotePort);
            this.gbRemote.Location = new System.Drawing.Point(13, 69);
            this.gbRemote.Name = "gbRemote";
            this.gbRemote.Size = new System.Drawing.Size(185, 92);
            this.gbRemote.TabIndex = 7;
            this.gbRemote.TabStop = false;
            this.gbRemote.Text = "Remote:";
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.tbLocalIPAddress);
            this.gbLocal.Controls.Add(this.lblLocalIPAddress);
            this.gbLocal.Controls.Add(this.btnCreteListener);
            this.gbLocal.Controls.Add(this.tbLocalPort);
            this.gbLocal.Controls.Add(this.lblLocalPort);
            this.gbLocal.Location = new System.Drawing.Point(242, 69);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(178, 92);
            this.gbLocal.TabIndex = 8;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "Local listener:";
            // 
            // tbLocalIPAddress
            // 
            this.tbLocalIPAddress.Location = new System.Drawing.Point(15, 37);
            this.tbLocalIPAddress.Name = "tbLocalIPAddress";
            this.tbLocalIPAddress.ReadOnly = true;
            this.tbLocalIPAddress.Size = new System.Drawing.Size(100, 20);
            this.tbLocalIPAddress.TabIndex = 8;
            this.tbLocalIPAddress.Text = "127.0.0.1";
            // 
            // lblLocalIPAddress
            // 
            this.lblLocalIPAddress.AutoSize = true;
            this.lblLocalIPAddress.Location = new System.Drawing.Point(12, 20);
            this.lblLocalIPAddress.Name = "lblLocalIPAddress";
            this.lblLocalIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblLocalIPAddress.TabIndex = 7;
            this.lblLocalIPAddress.Text = "IP Address:";
            // 
            // btnCreteListener
            // 
            this.btnCreteListener.Location = new System.Drawing.Point(93, 63);
            this.btnCreteListener.Name = "btnCreteListener";
            this.btnCreteListener.Size = new System.Drawing.Size(75, 23);
            this.btnCreteListener.TabIndex = 6;
            this.btnCreteListener.Text = "Create";
            this.btnCreteListener.UseVisualStyleBackColor = true;
            this.btnCreteListener.Click += new System.EventHandler(this.btnCreteListener_Click);
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(121, 37);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(47, 20);
            this.tbLocalPort.TabIndex = 3;
            this.tbLocalPort.Text = "7000";
            // 
            // lblLocalPort
            // 
            this.lblLocalPort.AutoSize = true;
            this.lblLocalPort.Location = new System.Drawing.Point(118, 20);
            this.lblLocalPort.Name = "lblLocalPort";
            this.lblLocalPort.Size = new System.Drawing.Size(29, 13);
            this.lblLocalPort.TabIndex = 2;
            this.lblLocalPort.Text = "Port:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(370, 390);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "UserName:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(18, 33);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(180, 20);
            this.tbUserName.TabIndex = 12;
            this.tbUserName.Text = "God";
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 176);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(408, 208);
            this.rtbChat.TabIndex = 13;
            this.rtbChat.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 425);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.gbRemote);
            this.Controls.Add(this.tbMessage);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbRemote.ResumeLayout(false);
            this.gbRemote.PerformLayout();
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoteIPAddress;
        private System.Windows.Forms.TextBox tbRemoteIP;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnRemoteSet;
        private System.Windows.Forms.GroupBox gbRemote;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.Button btnCreteListener;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.Label lblLocalPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbLocalIPAddress;
        private System.Windows.Forms.Label lblLocalIPAddress;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.RichTextBox rtbChat;
    }
}
