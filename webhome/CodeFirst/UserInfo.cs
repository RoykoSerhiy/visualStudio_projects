using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public enum VehicleType
    {
        Sedan = 0,
        Universal = 1,
        Hatchback = 2,
        Limousine = 3,
        Pickup = 4,
        Minivan = 5,
        Microvan = 6,
        Multivan = 7,
        Cupe = 8,
        Cabriolet = 9
    }
  
    public enum Nationality
    {
        Ukrainian = 0,
        American = 1,
        englishman = 2
    }
    [Table("UserInfo")]
    public class UserInfo
    {
        public UserInfo()
        {
            Roles = new List<Role>();
        }
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(60)]
        public string Surname { get; set; }
        [MaxLength(60)]
        public string MiddleName { get; set; }
        [MaxLength(60)]
        public string Phone { get; set; }
        [MaxLength(18)]
        [Index(IsUnique=true)]
        [Required]
        public string Login { get; set; }
        [MaxLength(18)]
        [Required]
        public string Password { get; set; }
        [Required]
        public Nationality Nationality { get; set; }
        public virtual List<Role> Roles { get; set; }
    }
    [Table("UserProfile")]
    public class User : UserInfo
    {
        public List<History> History { get; set; }
    }
    [Table("Street")]
    public class Street
    { 
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
    [Table("Region")]
    public class Region
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Street> Streets { get; set; }

    }
    [Table("City")]
    public class City
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Region> Regions { get; set; }
    }

    [Table("DriverProfile")]
    public class Driver : UserInfo
    {
        public Driver()
        {
            Car = new Car();
        }
        
        
        public List<History> History { get; set; }
        [Required]
        [MaxLength(6)]
        public string LicenseNum { get; set; }
        [Required]
        public DateTime LicenseValidDate { get; set; }
        public virtual Car Car { get; set; }
       

            
    }
    public class Role
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        public virtual List<UserInfo> Users { get; set; }

    }
    [Table("Admin")]
    public class Administrator : UserInfo
    {

    }
    [Table("Car")]
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string CarBrand { get; set; }
        [Required]
        [MaxLength(60)]
        public string CarModel { get; set; }
        [Required]
        public VehicleType VehicleType { get; set; }
        [Required]
        [MaxLength(8)]
        public string CarNumber { get; set; }
        [Required]
        [MaxLength(60)]
        public string CarClass { get; set; }
    }
    [Table("History")]
    public class History 
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Driver Driver { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime FinishTime { get; set; }
        [Required]
        [MaxLength(60)]
        public string DepatureAddress { get; set; }
        [Required]
        [MaxLength(60)]
        public string DestinationAddress { get; set; }
    }
}
