using CodeFirst;
using MvcClientSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcClientSite.Controllers
{
    public class QueueController : ApiController
    {
        public static List<DriverWorkModel> Queue = new List<DriverWorkModel>();
        [HttpPost]
        public void AddToQueue(DriverWorkModel dwm)
        {

            Queue.Add(dwm);
        }
        public void DeleteFomQueue(DriverWorkModel dwm)
        {
            Queue.Remove(dwm);
        }
        public DriverWorkModel GetDriverWorkModelById(int id)
        {
            return Queue.First(d => d.Driver.Id == id);
        }
        public int GetConunt()
        {
            return Queue.Count;
        }
        public bool HasSuchDriver(DriverWorkModel driver)
        {
            
            if (Queue.Exists(d => d.Driver.Id == driver.Driver.Id))
            {
                return true;
            }
            return false;
        }
    }
}
