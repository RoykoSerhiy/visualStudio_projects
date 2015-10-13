using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlExamples.CommonControls
{
    public partial class RegistrationControl : System.Web.UI.UserControl
    {
        public string Title { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            title.InnerText = Title ?? "New User Registration";
        }
        protected void chkLicense_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = (sender as CheckBox).Checked;
        }

        protected void btnSubmit_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = chkLicense.Checked;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            this.Page.Validate();

            if (this.Page.IsValid)
            {
                Session["UserName"] = string.Format("{0} {1}", txtSurname.Text, txtName.Text);
                Response.Redirect("~/ResultPage.aspx");
            }
        }
    }
}