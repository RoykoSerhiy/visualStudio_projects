using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace regform
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        [ScriptMethod]
        public string[] GetNameList(string prefixText, int count)
        {
           
            List<string> names = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                names.Add("Name" + i);
                if(i % 2 == 0)
                {
                    names.Add("Igor" + i);
                }
               
            }
           
            return names.Where(x => x.ToLower().Contains(prefixText.ToLower())).Take(count).ToArray();
        }
    }
}
