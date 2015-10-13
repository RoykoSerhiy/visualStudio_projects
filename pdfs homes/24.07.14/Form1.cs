using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._07._14
{
    public partial class Form1 : Form
    {
        List<string> files = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            files.AddRange(
                e.Data.GetData(DataFormats.FileDrop , false) as string[]
                );
            textBox1.Text = "";

            foreach(string file in files)
            {
                textBox1.Text += file + "\r\n";
            }
        }
    }
}
