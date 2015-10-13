using CodeFirst;
using managerDll;
using MvcClientSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Controllers.Abstract
{
    public abstract class CallDriver : Controller
    {
        protected CallDriverModel CreateCallDriverModel(string userName)
        {
            CallDriverModel cdm = new CallDriverModel();
            CityManager cm = new CityManager();
            List<Street> streets = cm.GetStreets();

            cdm.Name = userName ?? string.Empty;
            cdm.StreetList = streets.Select(s => new SelectListItem { Text = s.Name , Value = s.Id.ToString() }).ToList();

            return cdm;
        }
    }
}
