using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonModalForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        Form1 form1 = null;


        private void button1_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.Close();
            }
            form1 = new Form1();
            form1.Show();
        }
    }
}
