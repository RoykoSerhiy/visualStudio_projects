using CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClientSite.Models
{
    public enum Status{
        Online = 0,
        Offline = 1,
        Vacant = 2,
        InRoad = 3
    }
    public class DriverWorkModel
    {
        public Driver Driver { get; set; }
        public Status Status { get; set; }
        public Region Region { get; set; }
        public string SignalR_id { get; set; }
        public DriverWorkModel(Driver driver, Status status, Region region)
        {
            this.Driver = driver;
            this.Status = status;
            this.Region = region;
        }
    }
}