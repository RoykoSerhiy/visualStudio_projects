using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._08._14
{
    public partial class Form1 : Form
    {
        List<Point> _points = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point p in _points)
            {
                g.FillEllipse(Brushes.Black, p.X, p.Y, 9f, 12f);
            }

            g.Dispose();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            _points.Add(new Point(e.X, e.Y));
            this.Refresh();
        }
    }
}
