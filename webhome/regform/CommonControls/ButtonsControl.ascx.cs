﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.CommonControls
{
    public partial class ButtonsControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void chkLicense_CheckedChanged(object sender, EventArgs e)
        {
            //btnSubmit.Enabled = (sender as CheckBox).Checked;
        }

        protected void btnSubmit_Load(object sender, EventArgs e)
        {
            //btnSubmit.Enabled = chkLicense.Checked;
        }
    }
}