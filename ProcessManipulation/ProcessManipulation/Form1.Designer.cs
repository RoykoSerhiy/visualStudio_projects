namespace ProcessManipulation
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRunCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvailebleAssemblies = new System.Windows.Forms.ListBox();
            this.StartedProcess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(201, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(177, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(201, 104);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(177, 29);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(201, 139);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(177, 29);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.Text = "Close Window";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(201, 174);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(177, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRunCalc
            // 
            this.btnRunCalc.Location = new System.Drawing.Point(201, 210);
            this.btnRunCalc.Name = "btnRunCalc";
            this.btnRunCalc.Size = new System.Drawing.Size(177, 29);
            this.btnRunCalc.TabIndex = 6;
            this.btnRunCalc.Text = "Run Calc";
            this.btnRunCalc.UseVisualStyleBackColor = true;
            this.btnRunCalc.Click += new System.EventHandler(this.btnRunCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avalible Assemblies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Started Process";
            // 
            // AvailebleAssemblies
            // 
            this.AvailebleAssemblies.FormattingEnabled = true;
            this.AvailebleAssemblies.Location = new System.Drawing.Point(14, 39);
            this.AvailebleAssemblies.Name = "AvailebleAssemblies";
            this.AvailebleAssemblies.Size = new System.Drawing.Size(166, 225);
            this.AvailebleAssemblies.TabIndex = 9;
            this.AvailebleAssemblies.SelectedIndexChanged += new System.EventHandler(this.AvailebleAssemblies_SelectedIndexChanged);
            // 
            // StartedProcess
            // 
            this.StartedProcess.FormattingEnabled = true;
            this.StartedProcess.Location = new System.Drawing.Point(396, 39);
            this.StartedProcess.Name = "StartedProcess";
            this.StartedProcess.Size = new System.Drawing.Size(166, 225);
            this.StartedProcess.TabIndex = 10;
            this.StartedProcess.SelectedIndexChanged += new System.EventHandler(this.StartedProcess_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 289);
            this.Controls.Add(this.StartedProcess);
            this.Controls.Add(this.AvailebleAssemblies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunCalc);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRunCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AvailebleAssemblies;
        private System.Windows.Forms.ListBox StartedProcess;
    }
}

