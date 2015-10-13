using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ешьук
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            timer.Tick += new EventHandler(ShowTimer);
            

        }
        void ShowTimer(object tobj , EventArgs e)
        {
            timer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            MessageBox.Show("You have to go out" , "Out"
                ,MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Кількість хвилин повинна бути більше за 0");
                return;

            }
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            timer.Interval = (int)numericUpDown1.Value * 1000;
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            MessageBox.Show("The task is canceled", "Timer", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
