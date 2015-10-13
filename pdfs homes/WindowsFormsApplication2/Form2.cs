using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {


        public delegate void myEvent(object sender , EventArgs e);
        public event myEvent dlgEvent;
        public string TextBox
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = btnLeft;
            this.CancelButton = btnRight;
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            dlgEvent(this, e);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Left Item";
            dlgEvent(this, e);

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Right Item";
            dlgEvent(this, e);
        }
    }
}
