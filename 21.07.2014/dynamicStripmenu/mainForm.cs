using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicStripmenu
{
    public partial class mainForm : Form
    {
        MenuStrip menu;

        public mainForm()
        {
            InitializeComponent();
            menu = new MenuStrip();
            ToolStripMenuItem file =
                menu.Items.Add("File") as ToolStripMenuItem;
            ToolStripMenuItem edit = 
                menu.Items.Add("Edit") as ToolStripMenuItem;
            this.MainMenuStrip = menu;
            this.Controls.Add(menu);

            edit.DropDownItems.Add("Cut");
            edit.DropDownItems.Add(new ToolStripSeparator());
            edit.DropDownItems.Add("Copy");
            
            edit.DropDownItems.Add(new ToolStripSeparator());
            edit.DropDownItems.Add("Paste");


            ToolStripMenuItem close =
                file.DropDownItems.Add("Close") as ToolStripMenuItem;
            close.ShortcutKeys = Keys.Alt | Keys.C;
            close.ShowShortcutKeys = true;

            close.Click += new EventHandler(close_Click);
            
        }
        void close_Click(object sendet, EventArgs e)
        {
            this.Close();
        }


    }
}
