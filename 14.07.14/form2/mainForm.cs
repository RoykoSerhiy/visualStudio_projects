using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class mainForm : Form
    {
        Label label;
        public mainForm()
        {
            InitializeComponent();
            CreateLabel();
        }
        void CreateLabel()
        {
            label = new Label();
            Image img = Image.FromFile(@"D:\ZH-xB5KmUXE.jpg");
            label.Size = img.Size;
            label.Image = img;
            this.ClientSize = img.Size;
            Controls.Add(label);
        }
    }
}
