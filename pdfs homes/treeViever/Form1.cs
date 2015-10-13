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

namespace treeViever
{
    public partial class Form1 : Form
    {
        TreeNode modelessTN;
        string path = "";
        string mask = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //path = textBox1.Text;
            //mask = textBox2.Text;
            //modelessTN = treeView1.Nodes.Add(path);
            //string[] directories = Directory.GetDirectories(path);
            //
            //foreach(string d in directories)
            //{
            //   // modelessTN.Nodes.Add(d);
            //    string[] files = Directory.GetFiles(d);
            //    foreach(string f in files)
            //    {
            //        modelessTN.Nodes.Add(f);
            //    }
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                TreeNode node = new TreeNode(drive.Substring(0 , 1));
                node.Tag = drive;
                if (di.IsReady == true)
                {
                    node.Nodes.Add("...");
                }
                treeView1.Nodes.Add(node);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {

                    e.Node.Nodes.Clear();
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach(string dir in dirs)
                    {
                        if (dir != e.Node.Tag+"System Volume Information")
                        {
                            DirectoryInfo di = new DirectoryInfo(dir);
                            TreeNode node = new TreeNode(di.Name, 0, 1);

                            node.Tag = dir;
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...");
                             e.Node.Nodes.Add(node);
                        }
                        else
                        {
                            MessageBox.Show(dir);
                        }

                    }

                }
                



            }
        }
    }
}
