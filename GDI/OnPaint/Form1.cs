using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Graphics g = e.Graphics;
            Graphics g = this.CreateGraphics();
            Font f = new Font("LCD", 32, FontStyle.Bold);
            g.DrawString("GDI+", f, Brushes.Red, 10, 30);

            g.Dispose();

        }
    }
}
