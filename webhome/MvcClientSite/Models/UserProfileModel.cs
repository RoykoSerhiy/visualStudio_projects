using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Models
{
    public class UserProfileModel
    {
        
        public UserProfileModel()
        {
            NationalityList = GetEnumValues<Nationality>();
            
        }
        public List<SelectListItem> NationalityList { get; set; }
       


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

        [EnumDataType(typeof(Nationality))]
        public Nationality Nationality { get; set; }

        public List<History> History { get; set; }

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