using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25._08._14Print
{
    public partial class Form1 : Form
    {

        private Button _printButton = new Button();
        private PrintDocument _printDoc1 = new PrintDocument();
        Bitmap _memoryImage;

        private void CaptureScreen()
        {
            Graphics g = this.CreateGraphics();
            Size s = this.Size;
            _memoryImage = new Bitmap(s.Width , s.Height ,g);


            Graphics memoryGraphics = Graphics.FromImage(_memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            _printDoc1.Print();
        }
        private void printDocument1_PrintPage(object sender , PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_memoryImage, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();
            _printButton.Text = "Print me";
            _printButton.Click += new EventHandler(printButton_Click);
            _printDoc1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(_printButton);
        }
    }
}
