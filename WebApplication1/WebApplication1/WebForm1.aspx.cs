using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string text = "";
            if (NameText.Text != "")
            {
               
                    text = label_hello.Text += " a am ";
                    text += NameText.Text;
                    label_hello.Text = text;
                
            }
            else
            {
                text = "hello world";
                label_hello.Text = text;
            }
            
        }
    }
}