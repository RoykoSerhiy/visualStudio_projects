using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSerch
{
    public partial class childForm : Form
    {
        public delegate void myEvent(object sender, EventArgs e);
        public event myEvent dlgEvent;
        public string filesGet
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public childForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string res_Str = "";
            DirectoryInfo Dir = new DirectoryInfo(textBox1.Text);
            FileInfo[] files = Dir.GetFiles(textBox2.Text);
            if (files.Length == 0)
            {
                res_Str = textBox1.Text+" ("+textBox2.Text+")"+" Not found!";
               
            }
            else
            {
                foreach (FileInfo f in files)
                {
                    res_Str += f.FullName + "\r\n";

                }
                
            }
            textBox3.Text = res_Str;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dlgEvent(this, e);
            this.Close();
        }
    }
}
