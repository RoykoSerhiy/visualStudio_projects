namespace dz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RED = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.Tomato = new System.Windows.Forms.Label();
            this.Indigo = new System.Windows.Forms.Label();
            this.Yellow = new System.Windows.Forms.Label();
            this.Black = new System.Windows.Forms.Label();
            this.MainColor = new System.Windows.Forms.Label();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.ColorName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IsFill = new System.Windows.Forms.CheckBox();
            this.trackWidth = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.Aqua = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFigures = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // RED
            // 
            this.RED.BackColor = System.Drawing.Color.Red;
            this.RED.Location = new System.Drawing.Point(606, 133);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(27, 20);
            this.RED.TabIndex = 5;
            this.RED.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RED_MouseClick);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(649, 133);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(27, 20);
            this.Green.TabIndex = 6;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(606, 164);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(27, 20);
            this.Blue.TabIndex = 7;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Tomato
            // 
            this.Tomato.BackColor = System.Drawing.Color.Tomato;
            this.Tomato.Location = new System.Drawing.Point(649, 164);
            this.Tomato.Name = "Tomato";
            this.Tomato.Size = new System.Drawing.Size(27, 20);
            this.Tomato.TabIndex = 8;
            this.Tomato.Click += new System.EventHandler(this.Tomato_Click);
            // 
            // Indigo
            // 
            this.Indigo.BackColor = System.Drawing.Color.Indigo;
            this.Indigo.Location = new System.Drawing.Point(606, 194);
            this.Indigo.Name = "Indigo";
            this.Indigo.Size = new System.Drawing.Size(27, 20);
            this.Indigo.TabIndex = 9;
            this.Indigo.Click += new System.EventHandler(this.Indigo_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(649, 194);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(27, 20);
            this.Yellow.TabIndex = 10;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(606, 224);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(27, 20);
            this.Black.TabIndex = 11;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // MainColor
            // 
            this.MainColor.BackColor = System.Drawing.SystemColors.Control;
            this.MainColor.Location = new System.Drawing.Point(568, 36);
            this.MainColor.Name = "MainColor";
            this.MainColor.Size = new System.Drawing.Size(108, 57);
            this.MainColor.TabIndex = 12;
            // 
            // trackRed
            // 
            this.trackRed.AutoSize = false;
            this.trackRed.BackColor = System.Drawing.Color.Red;
            this.trackRed.Location = new System.Drawing.Point(570, 256);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(109, 30);
            this.trackRed.TabIndex = 13;
            this.trackRed.Scroll += new System.EventHandler(this.trackRed_Scroll);
            // 
            // trackGreen
            // 
            this.trackGreen.AutoSize = false;
            this.trackGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.trackGreen.Location = new System.Drawing.Point(571, 292);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(108, 30);
            this.trackGreen.TabIndex = 14;
            this.trackGreen.Scroll += new System.EventHandler(this.trackGreen_Scroll);
            // 
            // trackBlue
            // 
            this.trackBlue.AutoSize = false;
            this.trackBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.trackBlue.Location = new System.Drawing.Point(571, 328);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(108, 30);
            this.trackBlue.TabIndex = 15;
            this.trackBlue.Scroll += new System.EventHandler(this.trackBlue_Scroll);
            // 
            // ColorName
            // 
            this.ColorName.BackColor = System.Drawing.Color.White;
            this.ColorName.Location = new System.Drawing.Point(567, 7);
            this.ColorName.Name = "ColorName";
            this.ColorName.Size = new System.Drawing.Size(65, 17);
            this.ColorName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "B";
            // 
            // IsFill
            // 
            this.IsFill.Location = new System.Drawing.Point(412, 361);
            this.IsFill.Name = "IsFill";
            this.IsFill.Size = new System.Drawing.Size(55, 18);
            this.IsFill.TabIndex = 20;
            this.IsFill.Text = "IsFill";
            this.IsFill.UseVisualStyleBackColor = true;
            this.IsFill.CheckedChanged += new System.EventHandler(this.IsFill_CheckedChanged);
            // 
            // trackWidth
            // 
            this.trackWidth.AutoSize = false;
            this.trackWidth.Location = new System.Drawing.Point(253, 358);
            this.trackWidth.Maximum = 30;
            this.trackWidth.Minimum = 1;
            this.trackWidth.Name = "trackWidth";
            this.trackWidth.Size = new System.Drawing.Size(153, 21);
            this.trackWidth.TabIndex = 21;
            this.trackWidth.Value = 1;
            this.trackWidth.Scroll += new System.EventHandler(this.trackWidth_Scroll);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(131, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 22;
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(649, 224);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(27, 20);
            this.Aqua.TabIndex = 23;
            this.Aqua.Click += new System.EventHandler(this.Aqua_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 24;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 25);
            this.button5.TabIndex = 25;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFigures,
            this.mnSettings});
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // mnFigures
            // 
            this.mnFigures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.elipseToolStripMenuItem});
            this.mnFigures.Name = "mnFigures";
            this.mnFigures.Size = new System.Drawing.Size(160, 22);
            this.mnFigures.Text = "Figures";
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rectToolStripMenuItem.Text = "Rect";
            this.rectToolStripMenuItem.Click += new System.EventHandler(this.rectToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // mnSettings
            // 
            this.mnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.highToolStripMenuItem});
            this.mnSettings.Name = "mnSettings";
            this.mnSettings.Size = new System.Drawing.Size(160, 22);
            this.mnSettings.Text = "Graphic Settings";
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.lowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(649, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 27;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(606, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 28;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(567, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 29;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(567, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 30;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(568, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 31;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Chocolate;
            this.label12.Location = new System.Drawing.Point(567, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 32;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Chartreuse;
            this.label13.Location = new System.Drawing.Point(567, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 33;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 385);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackWidth);
            this.Controls.Add(this.IsFill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorName);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.MainColor);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Indigo);
            this.Controls.Add(this.Tomato);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.RED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RED;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Label Tomato;
        private System.Windows.Forms.Label Indigo;
        private System.Windows.Forms.Label Yellow;
        private System.Windows.Forms.Label Black;
        private System.Windows.Forms.Label MainColor;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label ColorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox IsFill;
        private System.Windows.Forms.TrackBar trackWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Aqua;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnFigures;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSettings;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

