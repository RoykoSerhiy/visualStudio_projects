using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.UserProfile
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile/AddUser.aspx");
        }

        protected void gwUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gwUsers.PageIndex = e.NewPageIndex;
            

        }
    }
}