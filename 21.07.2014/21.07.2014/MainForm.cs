using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._07._2014
{
    public partial class MainForm : Form
    {
        Color color;

        public MainForm()
        {
            InitializeComponent();
            color = this.BackColor;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = sender as ToolStripMenuItem;

            if (it.Checked)
            {
                this.BackColor = Color.Tomato;
            }
            else
            {
                this.BackColor = color;
            }
        }
    }
}
