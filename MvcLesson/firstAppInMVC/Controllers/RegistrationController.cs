using firstAppInMVC.Core;
using firstAppInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstAppInMVC.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            List<RegistrationModel> list = Session[Storage.DbKey] as List<RegistrationModel> ?? new List<RegistrationModel>();
            list.Add(model);
            Session[Storage.DbKey] = list;
            return RedirectToAction("List" , "User");
        }
    }
}
