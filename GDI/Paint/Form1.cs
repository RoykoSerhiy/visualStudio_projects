using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        //int mouse_x;
        //int mouse_y;


        int coords_X_Start;
        int coords_Y_Start;
        int coords_X_End;
        int coords_Y_End;
        bool _isRect;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRrect_Click(object sender, EventArgs e)
        {
            
            this.label1.Text = this.btnRrect.Text;
            _isRect = true;

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.btnLine.Text;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.btnElipse.Text;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //mouse_x = e.X;
            //mouse_y = e.Y;
            //string str = "m_x: " + mouse_x + "   m_y:  " + mouse_y +  " ";
            //this.label2.Text = str; 
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            coords_X_Start = e.X;
            coords_Y_Start = e.Y;
            label2.Text ="start= " +coords_X_Start.ToString() +" : "+ coords_Y_Start.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            coords_X_End = e.X;
            coords_Y_End = e.Y;
            label3.Text = "end= "+coords_X_End.ToString() + " : " + coords_Y_End.ToString();
        }

        private void btnRrect_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (_isRect == true)
            {
                Rectangle rect = new Rectangle(coords_X_Start, coords_Y_Start, coords_X_End-coords_X_Start, coords_Y_End-coords_Y_Start);
                g.DrawRectangle(new Pen(Brushes.Black, 2), rect);
            }

            g.Dispose();
        }
    }
}
