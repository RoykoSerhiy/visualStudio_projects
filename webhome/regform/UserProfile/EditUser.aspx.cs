using CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.UserProfile
{
    public partial class EditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btcCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile/UserList.aspx", true);
        }

        protected void ddlNationality_Init(object sender, EventArgs e)
        {
            var ddl = sender as DropDownList;

            Array itemValues = System.Enum.GetValues(typeof(Nationality));
            Array itemNames = System.Enum.GetNames(typeof(Nationality));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemNames.GetValue(i).ToString(), itemValues.GetValue(i).ToString());
                ddl.Items.Add(item);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile/UserList.aspx", false);
        }
    }
}