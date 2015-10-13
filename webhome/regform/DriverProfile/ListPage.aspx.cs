using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.DriverProfile
{
    public partial class ListPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DriverProfile/AddPage.aspx");
        }

        protected void gwDrivers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gwDrivers.PageIndex = e.NewPageIndex;
        }
    }
}