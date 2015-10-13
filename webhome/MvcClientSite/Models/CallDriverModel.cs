using CodeFirst;
using managerDll;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Models
{
    public class CallDriverModel
    {
        public CallDriverModel()
        {
            StreetList = GetStreets();
        }
        
        public List<SelectListItem> StreetList { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your name")]
        [Display(Name = "Enter your name")]
        [MaxLength(50)]
        [MinLength(4, ErrorMessage = "Name is too short")]
        public string Name { get; set; }

        public Street DepatureStreet { get; set; }

        public Street DestinationStreet { get; set; }

        public static List<SelectListItem> GetStreets()
        {
            CityManager cm = new CityManager();
            List<Street> streets = cm.GetStreets();
            return streets.Select(s => new SelectListItem { Text = s.Name, Value = s.Name.ToString() }).ToList();
        }
    }
}