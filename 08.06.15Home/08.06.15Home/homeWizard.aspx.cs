using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _08._06._15Home
{
    public partial class home : System.Web.UI.Page
    {
        public bool isLicense;
        protected void Page_Load(object sender, EventArgs e)
        {
            isLicense = false;
            tbxPath.Enabled = true;
        }

        protected void Unnamed_Activate(object sender, EventArgs e)
        {
            if (isLicense == true)
            {
                lbl_act.Text = "enter path";
                tbxPath.Enabled = true;
            }
            else
            {
                lbl_act.Text = "aprove license";
                tbxPath.Enabled = false;
            }
        }

       

        protected void chkLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLicense.Checked)
            {
                isLicense = true;
            }
            else
            {
                isLicense = false;
            }
            
        }

       

        protected void WizardStep1_Activate(object sender, EventArgs e)
        {
            if (tbxPath.Text == null)
            {
                lbl_act.Text = "Enter path";
                
            }
        }

        protected void Unnamed_Activate1(object sender, EventArgs e)
        {
            lbl_act.Text = "installed";
        }

        protected void mainWizard_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            lbl_act.Text = "next clicked";
        }
    }
}