namespace CourceWork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbFlashes = new System.Windows.Forms.ListBox();
            this.btnAddToWhiteList = new System.Windows.Forms.Button();
            this.btnDeleteFromWhiteList = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLowest = new System.Windows.Forms.RadioButton();
            this.rbBeloweNormal = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbAboveNormal = new System.Windows.Forms.RadioButton();
            this.rbHigest = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFormat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxDestPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFlashes
            // 
            this.lbFlashes.FormattingEnabled = true;
            this.lbFlashes.Location = new System.Drawing.Point(14, 17);
            this.lbFlashes.Name = "lbFlashes";
            this.lbFlashes.Size = new System.Drawing.Size(149, 82);
            this.lbFlashes.TabIndex = 0;
            // 
            // btnAddToWhiteList
            // 
            this.btnAddToWhiteList.Location = new System.Drawing.Point(14, 106);
            this.btnAddToWhiteList.Name = "btnAddToWhiteList";
            this.btnAddToWhiteList.Size = new System.Drawing.Size(33, 23);
            this.btnAddToWhiteList.TabIndex = 1;
            this.btnAddToWhiteList.Text = "+";
            this.btnAddToWhiteList.UseVisualStyleBackColor = true;
            this.btnAddToWhiteList.Click += new System.EventHandler(this.btnAddToWhiteList_Click);
            // 
            // btnDeleteFromWhiteList
            // 
            this.btnDeleteFromWhiteList.Location = new System.Drawing.Point(14, 135);
            this.btnDeleteFromWhiteList.Name = "btnDeleteFromWhiteList";
            this.btnDeleteFromWhiteList.Size = new System.Drawing.Size(33, 23);
            this.btnDeleteFromWhiteList.TabIndex = 2;
            this.btnDeleteFromWhiteList.Text = "-";
            this.btnDeleteFromWhiteList.UseVisualStyleBackColor = true;
            this.btnDeleteFromWhiteList.Click += new System.EventHandler(this.btnDeleteFromWhiteList_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(170, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(120, 138);
            this.lblInfo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLowest);
            this.groupBox1.Controls.Add(this.rbBeloweNormal);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbAboveNormal);
            this.groupBox1.Controls.Add(this.rbHigest);
            this.groupBox1.Location = new System.Drawing.Point(334, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread Priority";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbLowest
            // 
            this.rbLowest.AutoSize = true;
            this.rbLowest.Location = new System.Drawing.Point(6, 135);
            this.rbLowest.Name = "rbLowest";
            this.rbLowest.Size = new System.Drawing.Size(59, 17);
            this.rbLowest.TabIndex = 4;
            this.rbLowest.TabStop = true;
            this.rbLowest.Text = "Lowest";
            this.rbLowest.UseVisualStyleBackColor = true;
            this.rbLowest.CheckedChanged += new System.EventHandler(this.rbLowest_CheckedChanged);
            // 
            // rbBeloweNormal
            // 
            this.rbBeloweNormal.AutoSize = true;
            this.rbBeloweNormal.Location = new System.Drawing.Point(6, 97);
            this.rbBeloweNormal.Name = "rbBeloweNormal";
            this.rbBeloweNormal.Size = new System.Drawing.Size(94, 17);
            this.rbBeloweNormal.TabIndex = 3;
            this.rbBeloweNormal.TabStop = true;
            this.rbBeloweNormal.Text = "Belove Normal";
            this.rbBeloweNormal.UseVisualStyleBackColor = true;
            this.rbBeloweNormal.CheckedChanged += new System.EventHandler(this.rbBeloweNormal_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 74);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbAboveNormal
            // 
            this.rbAboveNormal.AutoSize = true;
            this.rbAboveNormal.Location = new System.Drawing.Point(6, 51);
            this.rbAboveNormal.Name = "rbAboveNormal";
            this.rbAboveNormal.Size = new System.Drawing.Size(92, 17);
            this.rbAboveNormal.TabIndex = 1;
            this.rbAboveNormal.TabStop = true;
            this.rbAboveNormal.Text = "Above Normal";
            this.rbAboveNormal.UseVisualStyleBackColor = true;
            this.rbAboveNormal.CheckedChanged += new System.EventHandler(this.rbAboveNormal_CheckedChanged);
            // 
            // rbHigest
            // 
            this.rbHigest.AutoSize = true;
            this.rbHigest.Location = new System.Drawing.Point(6, 19);
            this.rbHigest.Name = "rbHigest";
            this.rbHigest.Size = new System.Drawing.Size(55, 17);
            this.rbHigest.TabIndex = 0;
            this.rbHigest.TabStop = true;
            this.rbHigest.Text = "Higest";
            this.rbHigest.UseVisualStyleBackColor = true;
            this.rbHigest.CheckedChanged += new System.EventHandler(this.rbHigest_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(530, 22);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copy files to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mb";
            // 
            // tbxFormat
            // 
            this.tbxFormat.Enabled = false;
            this.tbxFormat.Location = new System.Drawing.Point(530, 48);
            this.tbxFormat.Name = "tbxFormat";
            this.tbxFormat.Size = new System.Drawing.Size(69, 20);
            this.tbxFormat.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbxDestPath
            // 
            this.tbxDestPath.Location = new System.Drawing.Point(105, 158);
            this.tbxDestPath.Name = "tbxDestPath";
            this.tbxDestPath.Size = new System.Drawing.Size(213, 20);
            this.tbxDestPath.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Destination Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Format";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(464, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Copy Sub Directories";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "USB";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 189);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDestPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDeleteFromWhiteList);
            this.Controls.Add(this.btnAddToWhiteList);
            this.Controls.Add(this.lbFlashes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "USB";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFlashes;
        private System.Windows.Forms.Button btnAddToWhiteList;
        private System.Windows.Forms.Button btnDeleteFromWhiteList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLowest;
        private System.Windows.Forms.RadioButton rbBeloweNormal;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbAboveNormal;
        private System.Windows.Forms.RadioButton rbHigest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFormat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxDestPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

