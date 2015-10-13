using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Darwing
{
    public partial class Form1 : Form
    {
        List<Point> _points = new List<Point>();

        Brush _brush = Brushes.Tomato;
        Graphics _g;
        public Form1()
        {
            InitializeComponent();
            _g = this.CreateGraphics();
            _g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _g.Dispose();
            _brush.Dispose();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            _points.Add(new Point(e.X, e.Y));
            this.Refresh();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Point p in _points)
            {
                _g.FillEllipse(_brush, p.X, p.Y, 9f, 12f);
            }
        }
    }
}
