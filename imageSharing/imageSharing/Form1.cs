using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageSharing
{
   
    public partial class Form1 : Form
    {
        public abstract class Picture
        {
            public Image i;

            public virtual Picture Clone()
            {
                var copy = (Picture)this.MemberwiseClone();
                return copy;
            }
        }
        public List<Image> images = new List<Image>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPicture();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void AddPicture()
        {
            string filePath = "";
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "JPEG (*.jpg)|*.jpg|Png (*.png)|*.png|All Files (*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                filePath = od.FileName;
            }
            images.Add(Image.FromFile(filePath));
            //MessageBox.Show(filePath);
        }
    }
}
