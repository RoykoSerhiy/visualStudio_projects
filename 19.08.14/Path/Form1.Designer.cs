namespace Path
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
            this.mnOperation = new System.Windows.Forms.MenuStrip();
            this.mnSelectOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnComplement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUnion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnIntersect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.mnXor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnOperation
            // 
            this.mnOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSelectOperationToolStripMenuItem});
            this.mnOperation.Location = new System.Drawing.Point(0, 0);
            this.mnOperation.Name = "mnOperation";
            this.mnOperation.Size = new System.Drawing.Size(284, 24);
            this.mnOperation.TabIndex = 0;
            this.mnOperation.Text = "menuStrip1";
            // 
            // mnSelectOperationToolStripMenuItem
            // 
            this.mnSelectOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnComplement,
            this.mnUnion,
            this.mnIntersect,
            this.mnExclude,
            this.mnXor});
            this.mnSelectOperationToolStripMenuItem.Name = "mnSelectOperationToolStripMenuItem";
            this.mnSelectOperationToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mnSelectOperationToolStripMenuItem.Text = "Select Operation";
            // 
            // mnComplement
            // 
            this.mnComplement.Name = "mnComplement";
            this.mnComplement.Size = new System.Drawing.Size(152, 22);
            this.mnComplement.Text = "Complement";
            this.mnComplement.Click += new System.EventHandler(this.mnComplement_Click);
            // 
            // mnUnion
            // 
            this.mnUnion.Name = "mnUnion";
            this.mnUnion.Size = new System.Drawing.Size(152, 22);
            this.mnUnion.Text = "Union";
            this.mnUnion.Click += new System.EventHandler(this.mnUnion_Click);
            // 
            // mnIntersect
            // 
            this.mnIntersect.Name = "mnIntersect";
            this.mnIntersect.Size = new System.Drawing.Size(152, 22);
            this.mnIntersect.Text = "Intersect";
            this.mnIntersect.Click += new System.EventHandler(this.mnIntersect_Click);
            // 
            // mnExclude
            // 
            this.mnExclude.Name = "mnExclude";
            this.mnExclude.Size = new System.Drawing.Size(152, 22);
            this.mnExclude.Text = "Exclude";
            this.mnExclude.Click += new System.EventHandler(this.mnExclude_Click);
            // 
            // mnXor
            // 
            this.mnXor.Name = "mnXor";
            this.mnXor.Size = new System.Drawing.Size(152, 22);
            this.mnXor.Text = "Xor";
            this.mnXor.Click += new System.EventHandler(this.mnXor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mnOperation);
            this.MainMenuStrip = this.mnOperation;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.mnOperation.ResumeLayout(false);
            this.mnOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnOperation;
        private System.Windows.Forms.ToolStripMenuItem mnSelectOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnComplement;
        private System.Windows.Forms.ToolStripMenuItem mnUnion;
        private System.Windows.Forms.ToolStripMenuItem mnIntersect;
        private System.Windows.Forms.ToolStripMenuItem mnExclude;
        private System.Windows.Forms.ToolStripMenuItem mnXor;
    }
}

