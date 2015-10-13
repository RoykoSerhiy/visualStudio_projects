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

namespace pdfs_homes
{
    public partial class Form1 : Form
    {
        childForm child = null;
       
        public Form1()
        {
            InitializeComponent();
            
                btnEdit.Enabled = false;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void dlgEvent(object sender, EventArgs e)
        {
            childForm objModeless = sender as childForm;
            if (objModeless != null)
            {
                textBox1.Text = objModeless.tb1Text;
            }

            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            child = new childForm(textBox1.Text);
            child.dlgEvent += dlgEvent;

            child.Show();
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt||";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                this.Text = open.FileName;
                reader.Close();
            }
            if (textBox1.Text != null)
            {
                btnEdit.Enabled = true;
            }
        }

        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt||";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           // string str2 = C_Form.textBox1.Text;
           // textBox1.Text = str2;
           // this.Update();
            
        }
    }
}
