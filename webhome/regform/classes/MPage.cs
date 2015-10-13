using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace regform.classes
{
    public class MPage : System.Web.UI.Page
    {
        protected string extractTextBoxValue(FormView fv,string controlID)
        {
            try
            {
                return (fv.FindControl(controlID) as TextBox).Text;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }

        }
    }
}