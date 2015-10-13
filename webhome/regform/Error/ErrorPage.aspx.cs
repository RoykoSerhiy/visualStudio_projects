using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.Error
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        private class ErrorDetails
        {
            public string What { get; set; }
            public string Why { get; set; }
            public string Suggestion { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Exception error = Server.GetLastError();
            ErrorDetails errorDetails = GetErrorDetails(GetExceptionCause(error));
            DisplayErrorDetails(errorDetails);
            Server.ClearError();
        }
        private void DisplayErrorDetails(ErrorDetails errorDetails)
        {
            lblWhat.Text = errorDetails.What;
            lblWhy.Text = errorDetails.Why;
            lblSuggestion.Text = errorDetails.Suggestion;
        }

        private Exception GetExceptionCause(Exception error)
        {
            while (error.InnerException != null)
            {
                error = error.InnerException;
            }
            return error;
        }

        private ErrorDetails GetErrorDetails(Exception error)
        {
            ErrorDetails errorDetails = new ErrorDetails();
            if (error is HttpException && (error as HttpException).GetHttpCode() == 404)
            {
                ErrorCode.Text = (error as HttpException).GetHashCode().ToString();
                errorDetails.What = "Requested resource could not be found";
                errorDetails.Why = "Specified url is incorrect.";
                errorDetails.Suggestion = "Check the specified url.";
            }
            else if (error is SqlException)
            {
                ErrorCode.Text = "Database error";
                errorDetails.What = "Maybe borke Database";
                errorDetails.Why = "Could not established connection with database";
                errorDetails.Suggestion = "Report problem to the system administrator";
            }
            else if (error is ApplicationException)
            {
                ErrorCode.Text = "Application Broken";
                errorDetails.What = "Oupps!.. Somesing wrong happened";
                errorDetails.Why = "You broke it all :(";
                errorDetails.Suggestion = "Please, try again later";
            }
            else
            {
                ErrorCode.Text = "Unexpected Error";
                errorDetails.What = "Unexpected Error";
                errorDetails.Why = "Undefined";
                errorDetails.Suggestion = "Resolved programers";
            }
            return errorDetails;
        }
    }
}