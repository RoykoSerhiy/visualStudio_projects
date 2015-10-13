using CodeFirst;
using managerDll;
using MvcClientSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        public ActionResult DriverRegister()
        {
            
            DriverRegistrationModel drm = new DriverRegistrationModel();
            return View("DriverRegister", drm);
        }
        public ActionResult UserRegister()
        {

            UserRegistrationModel urm = new UserRegistrationModel();
            return View("UserRegister", urm);
        }
        [HttpPost]
        public ActionResult DriverRegister(DriverRegistrationModel model)
        {
            AuthenticationProvider ap = new AuthenticationProvider();
            if(ap.LoginMach(model.Login))
            {
                ModelState.AddModelError("Login", "Login must be unique");
                return View("DriverRegister" , model);
            }
            DriverManager dm = new DriverManager();
            DriverRegistrationModel drm = new DriverRegistrationModel();
            if (ModelState.IsValid)
            {
                
                dm.Insert(GetDriver(model));
            }
            
            return View("DriverRegister", drm);
        }
        [HttpPost]
        public ActionResult UserRegister(UserRegistrationModel model)
        {
            AuthenticationProvider ap = new AuthenticationProvider();
            if (ap.LoginMach(model.Login))
            {
                ModelState.AddModelError("Login", "Login must be unique");
                return View("UserRegister", model);
            }
            UserManager um = new UserManager();
            UserRegistrationModel urm = new UserRegistrationModel();
            if (ModelState.IsValid)
            {

                um.Insert(GetUser(model));
            }

            return View("UserRegister", urm);
        }
        private Driver GetDriver(DriverRegistrationModel model)
        {
            
            Car car = new Car { 
                CarBrand = model.CarBrand,
                CarModel = model.CarModel,
                VehicleType = model.VehicleType,
                CarNumber = model.CarNumber,
                CarClass = model.CarClass
                };
            Driver driver = new Driver { 
                Name = model.Name,
                Surname = model.Surname,
                MiddleName = model.Middlename,
                Phone = model.Phone,
                Login = model.Login,
                Password = model.Password,
                LicenseNum = model.LicenseNumber,
                LicenseValidDate = model.LicenseValidDate,
                Nationality = model.Nationality,
                Car = car
            };

            return driver;
            
        }

        private User GetUser(UserRegistrationModel model)
        {
            User user = new User
            {
                Name = model.Name,
                Surname = model.Surname,
                MiddleName = model.Middlename,
                Phone = model.Phone,
                Login = model.Login,
                Password = model.Password,
                Nationality = model.Nationality
            };
            return user;
        }

        
    }
}
