using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.UserProfile.History
{
    public partial class UserHistoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gwHistory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gwHistory.PageIndex = e.NewPageIndex;
        }
    }
}