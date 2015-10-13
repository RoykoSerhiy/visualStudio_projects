using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;
using CodeFirst;
using managerDll;
using MvcClientSite.Models;
using System.Collections;
using MvcClientSite.Controllers;

namespace MvcClientSite.Hubs
{
    public class DriverHub : Hub
    {
        public string addToQueue(int driverId , int regionId)
        {
            //Clients.All.hello(data);
            DriverManager dm = new DriverManager();
            CityManager cm = new CityManager();
            Region region = cm.GetRegionsById(regionId);
            Driver driver = dm.GetById(driverId);
            DriverWorkModel driver_wm = new DriverWorkModel(driver, Status.Online, region);
            driver_wm.SignalR_id = Context.ConnectionId;
            QueueController queueController = new QueueController();
            
            if (!queueController.HasSuchDriver(driver_wm))
            {
                queueController.AddToQueue(driver_wm);
                Groups.Add(driver_wm.SignalR_id, "Drivers");
                 return "queue count:" + queueController.GetConunt();
            }
            return "this driver is alredy added in queue";
        }
       public string delFromQueue(int driverId)
       {
            QueueController queueController = new QueueController();
            DriverWorkModel dwm = queueController.GetDriverWorkModelById(driverId);
            if (queueController.HasSuchDriver(dwm))
            {
                queueController.DeleteFomQueue(dwm);
                Groups.Remove(dwm.SignalR_id, "Drivers");
                return "Driver with id:"+dwm.Driver.Id+" and Name:"+ dwm.Driver.Name + " deleted from queue!Queue size:" + queueController.GetConunt();
            }
            return "No such driver in queue";
       }
       public Driver SendReqest()
       {
           foreach(var dwm in QueueController.Queue)
           {
               this.Clients.Group("Drivers").;
           }
       }
       
    }
}