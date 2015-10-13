using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._07._14
{
    public partial class mainForm : Form
    {
        Label label;



        public mainForm()
        {
            InitializeComponent();
            label = new Label();
            label.Location = new Point(25, 25);
            label.Text = "LABEL1";
            label.AutoSize = true;
            Controls.Add(label);
        }
    }
}
