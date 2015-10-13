using firstAppInMVC.Core;
using firstAppInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstAppInMVC.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult List()
        {
          var list = Session[Storage.DbKey] as List<RegistrationModel> ?? new List<RegistrationModel>();
            return View(list);
        }

    }
}
