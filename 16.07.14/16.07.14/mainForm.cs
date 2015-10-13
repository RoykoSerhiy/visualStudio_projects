using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._07._14
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string str;
            str = DateTime.Now.ToShortTimeString();
            toolStripStatusLabel1.Text = str;
            str = DateTime.Now.DayOfWeek.ToString();
            dayOfAWeekToolStripMenuItem.Text = str;
            toolStripStatusLabel2.Text = DateTime.Now.Date.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str;
            str = DateTime.Now.ToShortTimeString();
            toolStripStatusLabel1.Text = str;
            str = DateTime.Now.DayOfWeek.ToString();
            dayOfAWeekToolStripMenuItem.Text = str;
            toolStripStatusLabel2.Text = DateTime.Now.Date.ToString();
        }
    }
}
