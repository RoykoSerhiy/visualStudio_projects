using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicMoney
{
    public partial class Form1 : Form
    {
        //Rectangle rect;
        Point p;
        public Form1()
        {
            InitializeComponent();
            p.X = 100;
            p.Y = 300;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Black , 2), 10, 10, 10 ,300);
            g.DrawLine(new Pen(Brushes.Black, 2) , 10  , 300 , 600 , 300);
            g.FillEllipse(Brushes.Red, p.X-5, p.Y, 10, 10);
            g.Dispose();
        }
    }
}
