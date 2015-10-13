using managerDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CF = CodeFirst;

namespace regform.DriverProfile.History
{
    public partial class DriverHistoryEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Response.Redirect(string.Format("~/DriverProfile/History/DriverHistoryList.aspx?uid={0}", Request.QueryString["uid"]), true);
        }

        protected void btcCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DriverProfile/ListPage.aspx", true);
        }

        protected void dsHistory_Updating(object sender, ObjectDataSourceMethodEventArgs e)
        {
            CF.History history = e.InputParameters[0] as CF.History;
            DriverManager dm = new DriverManager();
            UserManager um = new UserManager();
            history.Driver = dm.GetById(Convert.ToInt32((fvEditHistory.FindControl("ddlDrivers") as DropDownList).SelectedValue));
            history.User = um.GetById(Convert.ToInt32((fvEditHistory.FindControl("ddlUsers") as DropDownList).SelectedValue));
        }
    }
}