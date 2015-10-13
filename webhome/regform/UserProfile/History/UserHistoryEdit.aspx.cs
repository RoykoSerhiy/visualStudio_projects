using CodeFirst;
using managerDll;
using regform.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CF = CodeFirst;

namespace regform.UserProfile.History
{
    public partial class UserHistoryEdit : MPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Response.Redirect(string.Format("~/UserProfile/History/UserHistoryList.aspx?uid={0}", Request.QueryString["uid"]), true);
            
        }

        protected void btcCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile/UserList.aspx" , true);
        }

        protected void dsHistory_Updating(object sender, ObjectDataSourceMethodEventArgs e)
        {
            CF.History history = e.InputParameters[0] as CF.History;
            DriverManager dm = new DriverManager();
            UserManager um = new UserManager();
            history.Driver = dm.GetById(Convert.ToInt32((fvEditHistory.FindControl("ddlDrivers") as DropDownList).SelectedValue));
            history.User = um.GetById(Convert.ToInt32((fvEditHistory.FindControl("ddlUsers") as DropDownList).SelectedValue));
            history.StartTime = Convert.ToDateTime(extractTextBoxValue(fvEditHistory, "txtSDate"));
            history.FinishTime = Convert.ToDateTime(extractTextBoxValue(fvEditHistory, "txtFDate"));
        }
    }
}