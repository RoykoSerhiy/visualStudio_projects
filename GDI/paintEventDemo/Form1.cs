using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintEventDemo
{
    public partial class Form1 : Form
    {

        int _paintCount;
        public Form1()
        {
            InitializeComponent();
            _paintCount = 0;
            //this.Show();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Rectangle rect = new Rectangle(0, 0, 250, 180);
            g.FillRectangle(redBrush, rect);
            this.label1.Text = String.Format("PaintCount: {0}", _paintCount++);
        }
    }
}
