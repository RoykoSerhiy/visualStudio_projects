using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            int val = 100;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = val;
            progressBar1.Step = 1;

            
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            progressBar1.PerformStep();
            label1.Text = progressBar1.Value.ToString() + "%";
            this.Update();

        }

        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt||";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                this.Text = open.FileName;
                reader.Close();
            }
        }
                
    }
}
