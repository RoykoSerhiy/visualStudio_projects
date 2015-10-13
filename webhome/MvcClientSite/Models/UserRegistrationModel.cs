using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Models
{
    public class UserRegistrationModel
    {
        public UserRegistrationModel()
        {
            NationalityList = GetEnumValues<Nationality>();
           
        }
        public List<SelectListItem> NationalityList { get; set; }
        public List<SelectListItem> VehicleTypeList { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your name")]
        [Display(Name = "Enter your name")]
        [MaxLength(50)]
        [MinLength(4, ErrorMessage = "Name is too short")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your surname")]
        [MaxLength(50)]
        [MinLength(4, ErrorMessage = "Surname is too short")]
        [Display(Name = "Enter your surname")]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your middlename")]
        [MaxLength(50)]
        [MinLength(4, ErrorMessage = "Middlename is too short")]
        [Display(Name = "Enter your middlename")]
        public string Middlename { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your phone")]
        [MaxLength(14)]
        [MinLength(5, ErrorMessage = "Phone is too short")]
        [Display(Name = "Enter your phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your login")]
        [MaxLength(18)]
        [MinLength(5, ErrorMessage = "Login is too short")]
        [Display(Name = "Enter your login")]
        public string Login { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your password")]
        [MaxLength(18)]
        [MinLength(5, ErrorMessage = "Password is too short")]
        [Display(Name = "Enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EnumDataType(typeof(Nationality))]
        public Nationality Nationality { get; set; }

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