using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace firstAppInMVC.Models
{
    public class RegistrationModel
    {
        [Required(AllowEmptyStrings=false , ErrorMessage="Enter name")]
        [Display(Name="Enter your Name")]
        [MaxLength(50)]
        [MinLength(5 , ErrorMessage="Name is to short")]
        public string Name { get; set; }
        
        [Required(AllowEmptyStrings=false , ErrorMessage="Enter surname")]
        [Display(Name="Enter your surname")]
        [MaxLength(50)]
        [MinLength(5 ,ErrorMessage="Surname is t short")]
        public string Surname { get; set; }
        
        [Display(Name="Enter your age")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter age")]
        [DataType(DataType.Date)]
        public DateTime Age { get; set; }
       
        [Display(Name="Enter Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}