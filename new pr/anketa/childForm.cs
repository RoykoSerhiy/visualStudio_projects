using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketa
{
    public partial class childForm : Form
    {
        public string uName
        {
            get { return textBox1.Text; }
        }
        public string Country
        {
            get { return textBox2.Text; }
        }
        public string City
        {
            get { return textBox3.Text; }
        }
        public string Sex = "not";

        public string Date
        {
            get { return dateTimePicker1.Value.ToLongDateString(); }
        }
        public string About
        {
            get { return textBox4.Text; }
        }
        public childForm()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Sex = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Sex = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Sex = radioButton3.Text;
        }
    }
}
