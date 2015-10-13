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

namespace progress
{
    public partial class Form1 : Form
    {
        int max = 51;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = max;
            progressBar1.Step = 1;
            label2.Text = "Max char:" + (max - 1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                label1.Text = progressBar1.Value.ToString();
                progressBar1.PerformStep();
            }
            else
            {

                MessageBox.Show("Limit");

                return;
            }

            
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
