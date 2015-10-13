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

namespace formsAnket
{
    public partial class childForm : Form
    {
        public childForm()
        {
            InitializeComponent();
        }
        public string tb1Text
        {
            set { tb1Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt||";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
