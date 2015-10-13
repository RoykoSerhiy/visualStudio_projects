using CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.UserProfile
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile/UserList.aspx", false);
        }

        protected void ddlNationality_Load(object sender, EventArgs e)
        {
            DropDownList ddl = sender as DropDownList;

            Array itemValues = System.Enum.GetValues(typeof(Nationality));
            Array itemNames = System.Enum.GetNames(typeof(Nationality));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemValues.GetValue(i).ToString(), itemValues.GetValue(i).ToString());
                ddl.Items.Add(item);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile/UserList.aspx" , true);
        }
    }
}