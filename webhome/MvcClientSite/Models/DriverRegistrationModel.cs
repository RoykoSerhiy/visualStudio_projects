using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Models
{
    public class DriverRegistrationModel
    {

        public DriverRegistrationModel()
        {
            NationalityList = GetEnumValues<Nationality>();
            VehicleTypeList = GetEnumValues<VehicleType>();
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

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your license number")]
        [MaxLength(50)]
        [MinLength(5, ErrorMessage = "License number is too short")]
        [Display(Name = "Enter your license number")]
        public string LicenseNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your license valid date")]
        [Display(Name = "Your license valid date")]
        [DataType(DataType.Date)]
        public DateTime LicenseValidDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your car brand")]
        [MaxLength(50)]
        [MinLength(3, ErrorMessage = "Car brand is too short")]
        [Display(Name = "Enter your car barand")]
        public string CarBrand { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your car model")]
        [MaxLength(20)]
        [MinLength(2, ErrorMessage = "Car model is too short")]
        [Display(Name = "Enter your car model")]
        public string CarModel { get; set; }

        [EnumDataType(typeof(VehicleType))]
        public VehicleType VehicleType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your car number")]
        [MaxLength(8)]
        [MinLength(8, ErrorMessage = "Car number is too short")]
        [Display(Name = "Enter your car number")]
        public string CarNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You should enter your car class")]
        [MaxLength(3)]
        [MinLength(1, ErrorMessage = "Car class is too short")]
        [Display(Name = "Enter your car class")]
        public string CarClass { get; set; }

        public static List<SelectListItem> GetEnumValues<T>() where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }
            return Enum.GetValues(typeof(T)).Cast<T>().Select(e => new SelectListItem{ Value = e.ToString(), Text = e.ToString() }).ToList();
            //return enumValues.Select<SelectListItem>(i => new SelectListItem{Text = i}) //new List<SelectListItem> ;
        }

        //public static SelectList GetNationalitySelectList()
        //{
        //    var enumValues = Enum.GetValues(typeof(Nationality)).Cast<Nationality>().Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();

            
        //}
        //public static SelectList GetVehicleTypeSelectList()
        //{
        //    var enumValues = Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();

        //    return new SelectList(enumValues, "Value", "Text", "");
        //}

    }
}