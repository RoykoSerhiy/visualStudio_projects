using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlExamples
{
    public partial class ResultPage : System.Web.UI.Page
    {
        private static string greetingMsgFormat = "Congradulations! User {0} reistered successfully.";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = Session["UserName"] as string;
                var fullNameList = name.Split(" ".ToCharArray()).ToList();

                fullNameList = fullNameList.Select(n => char.ToUpper(n[0]) + n.Substring(1)).ToList();
                name = string.Join(" ", fullNameList);

                greetingMsg.InnerText = string.Format(greetingMsgFormat, name);
            }
        }
    }
}