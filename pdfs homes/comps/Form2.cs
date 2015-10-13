using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comps
{
    public partial class Form2 : Form
    {
        // string _name;
       

        /*
        public string GetName
        {
            get { return _name; }
        }
         */

        public string Name
        {
            get {  return textName.Text; }
            set { textName.Text = value; }
        }

        public string Processor
        {
            get { return textCpu.Text; }
            set { textCpu.Text = value; }
        }
        public string Motherboard
        {
            get { return textMotherboard.Text; }
            set { textMotherboard.Text = value; }
        }
        public string Ram
        {
            get { return textRam.Text; }
            set { textRam.Text = value; }
        }
        public string Hdd
        {
            get { return textHdd.Text; }
            set { textHdd.Text = value; }
        }
        public string Video
        {
            get { return textVideo.Text; }
            set { textVideo.Text = value; }
        }
        public string About
        {
            get { return textAbout.Text; }
            set { textAbout.Text = value; }
        }
        public string Price
        {
            get { return textPrice.Text; }
            set { textPrice.Text = value; }
        }
        
        public Form2(Comp c)
        {
            InitializeComponent();
            // this._name = c.GetName;
            this.Name = c.GetName;
            textName.Text = c.GetName;
            this.Motherboard = c.GetMotherboard;
            textMotherboard.Text = c.GetMotherboard;
            this.Processor = c.GetProcessor;
            textCpu.Text = c.GetProcessor;
            this.Ram = c.GetRam;
            textRam.Text = c.GetRam;
            this.Hdd = c.GetHdd;
            textHdd.Text = c.GetHdd;
            this.Video = c.GetVideo;
            textVideo.Text = c.GetVideo;
            this.About = c.GetAbout;
            textAbout.Text = c.GetAbout;
            this.Price = c.GetPrice.ToString();
            textPrice.Text = c.GetPrice.ToString();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;
           //_name   =  textName.Text;  
           Name = textName.Text;
           Processor = textCpu.Text;
           Motherboard = textMotherboard.Text;
           Ram = textRam.Text;
           Hdd = textHdd.Text;
           Video = textVideo.Text;
           About = textAbout.Text;
            
           //_price   = Convert.ToDouble(textPrice.Text);
            this.Close();
        }
    }
}
