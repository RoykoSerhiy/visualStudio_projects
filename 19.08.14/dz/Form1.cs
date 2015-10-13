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

namespace dz
{
    

    public partial class Form1 : Form
    {
        
        Graphics g;
        Pen p;
        bool _isDrawing = false;
        bool _isLine = false;
        bool _isRect = false;
        bool _isElipse = false;
        bool _isTableColor = true;
        bool _isFill = false;
        int graphicMode = 1;
        //bool _isAdded = false;
        Point A;
        Point B;
        Color c;
        int R;
        int G;
        int Bl;
        int lineWidth = 3;
        Brush brush;
        List<Figure> figure = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            switch(graphicMode)
            {
                case 1:
                    {
                        g.SmoothingMode = SmoothingMode.HighSpeed;
                    }break;
                case 2:
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                    }break;
                case 3:
                    {
                        g.SmoothingMode = SmoothingMode.HighQuality;
                    }break;
            }       
            this.label6.Text = "Line Width = " + lineWidth + " px";
            this.trackWidth.Value = lineWidth;
            this.label1.Text = "A...";
            this.label2.Text = "B...";
            button5.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            _isLine = true;
            _isRect = false;
            _isElipse = false;
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isLine == true || _isRect == true || _isElipse == true)
            {

                brush = new SolidBrush(c);
                if (_isTableColor == true)
                {
                    c = Color.FromArgb(R, G, Bl);
                    this.MainColor.BackColor = c;
                }
                if (!_isDrawing)
                {
                    A.X = e.X;
                    A.Y = e.Y;

                    label1.Text = "Point A:" + A.X + ";" + A.Y;
                    _isDrawing = true;
                    //this.button1.Enabled = false;
                }
                else
                {
                    B.X = e.X;
                    B.Y = e.Y;

                    label2.Text = "Point B:" + B.X + ";" + B.Y;
                    _isDrawing = false;
                    //this.button1.Enabled = true;

                    if (_isLine)
                    {
                        p = new Pen(c, lineWidth);

                        g.DrawLine(p, A, B);

                        //_isLine = false;
                    }
                    else
                        if (_isRect)
                        {
                            p = new Pen(c, lineWidth);



                            //g.DrawRectangle(p, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                            if (A.X < B.X && A.Y < B.Y)
                                g.DrawRectangle(p, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                            if (A.X < B.X && A.Y > B.Y)
                                g.DrawRectangle(p, A.X, B.Y, B.X - A.X, A.Y - B.Y);
                            if (A.X > B.X && A.Y < B.Y)
                                g.DrawRectangle(p, B.X, A.Y, A.X - B.X, B.Y - A.Y);
                            else
                                g.DrawRectangle(p, B.X, B.Y, A.X - B.X, A.Y - B.Y);
                            
                            if (_isFill == true)
                            {
                                //g.FillRectangle(brush, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                                if (A.X < B.X && A.Y < B.Y)
                                    g.FillRectangle(brush, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                                if (A.X < B.X && A.Y > B.Y)
                                    g.FillRectangle(brush, A.X, B.Y, B.X - A.X, A.Y - B.Y);
                                if (A.X > B.X && A.Y < B.Y)
                                    g.FillRectangle(brush, B.X, A.Y, A.X - B.X, B.Y - A.Y);
                                else
                                    g.FillRectangle(brush, B.X, B.Y, A.X - B.X, A.Y - B.Y);
                            }
                            //_isRect = false;
                        }
                        else
                            if (_isElipse)
                            {
                                p = new Pen(c, lineWidth);
                                g.DrawEllipse(p, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                                if (_isFill == true)
                                {
                                    g.FillEllipse(brush, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                                }
                                //_isElipse = false;
                            }

                    figure.Add(new Figure(A, B, p, c, brush, lineWidth, _isLine, _isRect, _isElipse, _isFill));
                    if (figure.Count > 0)
                    {
                        button5.Enabled = true;
                    }

                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            p = new Pen(Brushes.Gray, 2);
            p.DashStyle = DashStyle.DashDotDot;

            if (_isDrawing)
            {
                B.X = e.X;
                B.Y = e.Y;
                label2.Text = "Point B:" + B.X + ";" + B.Y;
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_isDrawing)
            {
                if(_isLine)
                {
                    g.DrawLine(p, A, B);
                }
                else
                    if (_isRect)
                    {
                       //g.DrawRectangle(p, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                        if (A.X < B.X && A.Y < B.Y)
                            g.DrawRectangle(p, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                        if (A.X < B.X && A.Y > B.Y)
                            g.DrawRectangle(p, A.X, B.Y, B.X - A.X, A.Y - B.Y);
                        if (A.X > B.X && A.Y < B.Y)
                            g.DrawRectangle(p, B.X, A.Y, A.X - B.X, B.Y - A.Y);
                        else
                            g.DrawRectangle(p, B.X, B.Y, A.X - B.X, A.Y - B.Y);
                    }
                    else
                        if (_isElipse)
                        {
                            g.DrawEllipse(p, A.X, A.Y, B.X - A.X, B.Y - A.Y);
                        }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            _isRect = true;
            _isElipse = false;
            _isLine = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            _isElipse = true;
            _isLine = false;
            _isRect = false;

        }

        private void RED_MouseClick(object sender, MouseEventArgs e)
        {
             //c = new Color();
             
                c = Color.Red;

                this.MainColor.BackColor = c;
                this.ColorName.Text = "Red";
                _isTableColor = false;
            
            
        }

        private void Green_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Green;
            
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Green";
            _isTableColor = false;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Blue;
            
            
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Blue";
            _isTableColor = false;
        }

        private void Tomato_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Tomato;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Tomato";
            _isTableColor = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Black;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Black";
        }

        private void Indigo_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Indigo;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Indigo";
            _isTableColor = false;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Yellow;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Yellow";
            _isTableColor = false;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Black;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Black";
            _isTableColor = false;
        }

        private void trackRed_Scroll(object sender, EventArgs e)
        {
            R = trackRed.Value;
            this.label3.Text = trackRed.Value.ToString();
            this.MainColor.BackColor = Color.FromArgb(R, G, Bl); 
            _isTableColor = true;
            
        }

        private void trackGreen_Scroll(object sender, EventArgs e)
        {
            G = trackGreen.Value;
            this.label4.Text = trackGreen.Value.ToString();
            this.MainColor.BackColor = Color.FromArgb(R, G, Bl); 
            _isTableColor = true;
        }

        private void trackBlue_Scroll(object sender, EventArgs e)
        {
            Bl = trackBlue.Value;
            this.label5.Text = trackBlue.Value.ToString();
            this.MainColor.BackColor = Color.FromArgb(R, G, Bl); 
            _isTableColor = true;
        }

        private void IsFill_CheckedChanged(object sender, EventArgs e)
        {
            _isFill = true;
            if (!IsFill.Checked)
            {
                _isFill = false;
            }
        
        }

        private void trackWidth_Scroll(object sender, EventArgs e)
        {
            lineWidth = trackWidth.Value;
            this.label6.Text = "Line Width = " + lineWidth + " px";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            figure.Clear();
            g.Dispose();
        }

        private void Aqua_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Aqua;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Aqua";
            _isTableColor = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figure)
            {
                if (f._isLine == true)
                {
                    g.DrawLine(f.p, f.A, f.B);
                }
                if (f._isRect == true)
                {
                    //g.DrawRectangle(f.p, f.A.X, f.A.Y, f.B.X - f.A.X, f.B.Y - f.A.Y);
                    if (f.A.X < f.B.X && f.A.Y < f.B.Y)
                        g.DrawRectangle(f.p, f.A.X, f.A.Y, f.B.X - f.A.X, f.B.Y - f.A.Y);
                    if (f.A.X < f.B.X && f.A.Y > f.B.Y)
                        g.DrawRectangle(f.p, f.A.X, f.B.Y, f.B.X - f.A.X, f.A.Y - f.B.Y);
                    if (f.A.X > f.B.X && f.A.Y < f.B.Y)
                        g.DrawRectangle(f.p, f.B.X, f.A.Y, f.A.X - f.B.X, f.B.Y - f.A.Y);
                    else
                        g.DrawRectangle(f.p, f.B.X, f.B.Y, f.A.X - f.B.X, f.A.Y - f.B.Y);
                    if (f._isFill == true)
                    {
                        //g.FillRectangle(f.brush, f.A.X, f.A.Y, f.B.X - f.A.X, f.B.Y - f.A.Y);
                        if (f.A.X < f.B.X && f.A.Y < f.B.Y)
                            g.FillRectangle(f.brush, f.A.X, f.A.Y, f.B.X - f.A.X, f.B.Y - f.A.Y);
                        if (f.A.X < f.B.X && f.A.Y > f.B.Y)
                            g.FillRectangle(f.brush, f.A.X, f.B.Y, f.B.X - f.A.X, f.A.Y - f.B.Y);
                        if (f.A.X > f.B.X && f.A.Y < f.B.Y)
                            g.FillRectangle(f.brush, f.B.X, f.A.Y, f.A.X - f.B.X, f.B.Y - f.A.Y);
                        else
                            g.FillRectangle(f.brush, f.B.X, f.B.Y, f.A.X - f.B.X, f.A.Y - f.B.Y);
                    }
                }
                if (f._isElipse == true)
                {
                    g.DrawEllipse(f.p, f.A.X, f.A.Y, f.B.X - f.A.X, f.B.Y - f.A.Y);
                    if (f._isFill == true)
                    {
                        g.FillEllipse(f.brush, f.A.X, f.A.Y, f.B.X - f.A.X, f.B.Y - f.A.Y);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            figure.Clear();
            this.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (figure.Count != 0)
            {
                figure.RemoveAt(figure.Count - 1);
                this.Refresh();
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            _isRect = true;
            _isElipse = false;
            _isLine = false;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            _isLine = true;
            _isRect = false;
            _isElipse = false;
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            _isElipse = true;
            _isLine = false;
            _isRect = false;
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicMode = 1;
            MessageBox.Show("Graphic Mode Low");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicMode = 2;
            MessageBox.Show("Graphic Mode Medium");
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicMode = 3;
            MessageBox.Show("Graphic Mode High");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Chartreuse;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Chartreuse";
            _isTableColor = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Chocolate;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Chocolate";
            _isTableColor = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Gold;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Gold";
            _isTableColor = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Maroon;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Maroon";
            _isTableColor = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Silver;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Silver";
            _isTableColor = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.Gray;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "Gray";
            _isTableColor = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            c = new Color();
            c = Color.DarkOrange;
            this.MainColor.BackColor = c;
            this.ColorName.Text = "DarkOrange";
            _isTableColor = false;
        }
    }
}
public class Figure
{
    public Point A;
    public Point B;
    public Pen p;
    public Color c;
    public Brush brush;
    public int lineWidth;
    public bool _isLine;
    public bool _isRect;
    public bool _isElipse;
    public bool _isFill;
    public Figure(Point a, Point b, Pen P, Color C, Brush br,int lw, bool _isline, bool _isrect, bool _iselipse, bool _isfill)
    {
        A = a;
        B = b;
        p = P;
        c = C;
        brush = br;
        lineWidth = lw;
        _isLine = _isline;
        _isRect = _isrect;
        _isElipse = _iselipse;
        _isFill = _isfill;
    }
}