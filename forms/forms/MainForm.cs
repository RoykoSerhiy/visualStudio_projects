using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //1
            //MessageBox.Show("C# is good               ","imporant message");


            //2
           //DialogResult res =  MessageBox.Show("is C# awesome?" , "important qestion" ,
           //     MessageBoxButtons.YesNo);
           //if (res == DialogResult.Yes)
           //{
           //    MessageBox.Show("Yes");
           //}
           //else
           //{
           //    MessageBox.Show("No");
           //}
            //3
            //MessageBox.Show("Is C# awesome" , "Important Qerry",
            //    MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            //4
            //MessageBox.Show("Is the Visual Basic awesome?","Qestions",
            //    MessageBoxButtons.YesNoCancel,
            //    MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button2);
           // MessageBox.Show("C# is the Best", "Critical Warning",
           //     MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
           //     MessageBoxDefaultButton.Button1,
           //     MessageBoxOptions.DefaultDesktopOnly);
            //MessageBox.Show("C# is Super" , "Is not" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation , MessageBoxDefaultButton.Button1);
            InitializeComponent();
        }
    }
}
