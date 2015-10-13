namespace ChatUdpExampleTest
{
    partial class Form1
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
            this.lblYourIP = new System.Windows.Forms.Label();
            this.txtYourIP = new System.Windows.Forms.TextBox();
            this.lblyouPort = new System.Windows.Forms.Label();
            this.txtYourPort = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblFriendPort = new System.Windows.Forms.Label();
            this.lblFriendIP = new System.Windows.Forms.Label();
            this.txtFriendIP = new System.Windows.Forms.TextBox();
            this.txtFriendPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYourIP
            // 
            this.lblYourIP.AutoSize = true;
            this.lblYourIP.Location = new System.Drawing.Point(12, 9);
            this.lblYourIP.Name = "lblYourIP";
            this.lblYourIP.Size = new System.Drawing.Size(42, 13);
            this.lblYourIP.TabIndex = 0;
            this.lblYourIP.Text = "Your IP";
            // 
            // txtYourIP
            // 
            this.txtYourIP.Location = new System.Drawing.Point(69, 6);
            this.txtYourIP.Name = "txtYourIP";
            this.txtYourIP.Size = new System.Drawing.Size(100, 20);
            this.txtYourIP.TabIndex = 1;
            // 
            // lblyouPort
            // 
            this.lblyouPort.AutoSize = true;
            this.lblyouPort.Location = new System.Drawing.Point(12, 43);
            this.lblyouPort.Name = "lblyouPort";
            this.lblyouPort.Size = new System.Drawing.Size(51, 13);
            this.lblyouPort.TabIndex = 2;
            this.lblyouPort.Text = "Your Port";
            // 
            // txtYourPort
            // 
            this.txtYourPort.Location = new System.Drawing.Point(69, 40);
            this.txtYourPort.Name = "txtYourPort";
            this.txtYourPort.Size = new System.Drawing.Size(100, 20);
            this.txtYourPort.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(634, 212);
            this.listBox1.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(178, 291);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(397, 33);
            this.txtMessage.TabIndex = 5;
            // 
            // lblFriendPort
            // 
            this.lblFriendPort.AutoSize = true;
            this.lblFriendPort.Location = new System.Drawing.Point(202, 43);
            this.lblFriendPort.Name = "lblFriendPort";
            this.lblFriendPort.Size = new System.Drawing.Size(58, 13);
            this.lblFriendPort.TabIndex = 6;
            this.lblFriendPort.Text = "Friend Port";
            // 
            // lblFriendIP
            // 
            this.lblFriendIP.AutoSize = true;
            this.lblFriendIP.Location = new System.Drawing.Point(202, 9);
            this.lblFriendIP.Name = "lblFriendIP";
            this.lblFriendIP.Size = new System.Drawing.Size(49, 13);
            this.lblFriendIP.TabIndex = 7;
            this.lblFriendIP.Text = "Friend IP";
            // 
            // txtFriendIP
            // 
            this.txtFriendIP.Location = new System.Drawing.Point(266, 2);
            this.txtFriendIP.Name = "txtFriendIP";
            this.txtFriendIP.Size = new System.Drawing.Size(100, 20);
            this.txtFriendIP.TabIndex = 8;
            this.txtFriendIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFriendPort
            // 
            this.txtFriendPort.Location = new System.Drawing.Point(266, 40);
            this.txtFriendPort.Name = "txtFriendPort";
            this.txtFriendPort.Size = new System.Drawing.Size(100, 20);
            this.txtFriendPort.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(383, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(262, 52);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(581, 291);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 33);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nick";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(54, 291);
            this.txtNick.Multiline = true;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(114, 33);
            this.txtNick.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 336);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFriendPort);
            this.Controls.Add(this.txtFriendIP);
            this.Controls.Add(this.lblFriendIP);
            this.Controls.Add(this.lblFriendPort);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtYourPort);
            this.Controls.Add(this.lblyouPort);
            this.Controls.Add(this.txtYourIP);
            this.Controls.Add(this.lblYourIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourIP;
        private System.Windows.Forms.TextBox txtYourIP;
        private System.Windows.Forms.Label lblyouPort;
        private System.Windows.Forms.TextBox txtYourPort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblFriendPort;
        private System.Windows.Forms.Label lblFriendIP;
        private System.Windows.Forms.TextBox txtFriendIP;
        private System.Windows.Forms.TextBox txtFriendPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNick;
    }
}

