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
    public partial class Form1 : Form
    {

        TreeNode modelessTN;
        Form2 child;

        public Form1()
        {
            InitializeComponent();
            modelessTN = treeView1.Nodes.Add("Modeless");
        }

        void dlgEvent(object sender, EventArgs e)
        {
            Form2 objModeless = sender as Form2;
            if (objModeless != null)
            {
                modelessTN.Nodes.Add(objModeless.TextBox);
            }

            treeView1.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            child = new Form2();
            child.dlgEvent += dlgEvent;

            child.Show();
        }
    }
}
