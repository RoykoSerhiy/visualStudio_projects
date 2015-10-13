using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rrrr
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
            timer.Tick += new EventHandler(showTime);
            timer.Interval = 500;
            timer.Start();
        }
        void showTime(object tobj , EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
