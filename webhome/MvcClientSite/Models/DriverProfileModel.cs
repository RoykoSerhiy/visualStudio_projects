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
    public class DriverProfileModel
    {
        public DriverProfileModel()
        {
            NationalityList = GetEnumValues<Nationality>();
            VehicleTypeList = GetEnumValues<VehicleType>();
            RegionsList = GetRegions();
        }
        public List<SelectListItem> NationalityList { get; set; }
        public List<SelectListItem> VehicleTypeList { get; set; }
        public List<SelectListItem> RegionsList { get; set; }


        public int Id { get; set; }
        //[Display(Name = "Name")]
        public string Name { get; set; }

       
        //[Display(Name = "Surname")]
        public string Surname { get; set; }

       
       // [Display(Name = "Middlename")]
        public string Middlename { get; set; }

       
       // [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

       
      //  [Display(Name = "Login")]
        public string Login { get; set; }

        
      //  [Display(Name = "License number")]
        public string LicenseNumber { get; set; }

       
      //  [Display(Name = "License valid date")]
        [DataType(DataType.Date)]
        public DateTime LicenseValidDate { get; set; }

       
      //  [Display(Name = "Car barand")]
        public string CarBrand { get; set; }

       
     //   [Display(Name = "Car model")]
        public string CarModel { get; set; }

        [EnumDataType(typeof(VehicleType))]
        public VehicleType VehicleType { get; set; }

       
     //   [Display(Name = "Car number")]
        public string CarNumber { get; set; }

        
      //  [Display(Name = "Car class")]
        public string CarClass { get; set; }

        public List<History> History { get; set; }

        public Region regions { get; set; }

        public static List<SelectListItem> GetRegions()
        {
            CityManager cm = new CityManager();
            List<Region> regions = cm.GetRegions();
            return regions.Select(r => new SelectListItem { Text = r.Name, Value = r.Id.ToString() }).ToList();
        }

        public static List<SelectListItem> GetEnumValues<T>() where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }
            return Enum.GetValues(typeof(T)).Cast<T>().Select(e => new SelectListItem { Value = e.ToString(), Text = e.ToString() }).ToList();
            //return enumValues.Select<SelectListItem>(i => new SelectListItem{Text = i}) //new List<SelectListItem> ;
        }

        
    }
}