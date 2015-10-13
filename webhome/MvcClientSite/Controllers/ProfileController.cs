using CodeFirst;
using managerDll;
using MvcClientSite.Controllers.Abstract;
using MvcClientSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientSite.Controllers
{
    public class ProfileController : CallDriver
    {
        //
        // GET: /Profile/

        public ActionResult ToProfile()
        {
            UserInfoManager uim = new UserInfoManager();
            HistoryManager hm = new HistoryManager();
            List<History> history;
            UserInfo ui = uim.GetByLogin(User.Identity.Name);
            if (ui is Driver)
            {
                history = hm.GetDriverHistory(ui.Id);
                return View("DriverProfile", GetDriverModel(ui as Driver , history));
            }
            history = hm.GetUserHistory(ui.Id);
            ViewBag.CallDriverModel = CreateCallDriverModel(ui.Name);
            return View("UserProfile", GetUserModel(ui as User , history));


        }

        public DriverProfileModel GetDriverModel(Driver driver , List<History> history)
        {
            DriverProfileModel dpm = new DriverProfileModel
            {
                Id = driver.Id,
                Name = driver.Name,
                Surname = driver.Surname,
                Middlename = driver.MiddleName,
                Phone = driver.Phone,
                Login = driver.Login,
                LicenseNumber = driver.LicenseNum,
                LicenseValidDate = driver.LicenseValidDate,
                CarBrand = driver.Car.CarBrand,
                CarModel = driver.Car.CarModel,
                CarClass = driver.Car.CarClass,
                CarNumber = driver.Car.CarNumber,
                VehicleType = driver.Car.VehicleType,
                History = history
                
            };
            return dpm;
        }
        public UserProfileModel GetUserModel(User user , List<History> history)
        {
            UserProfileModel upm = new UserProfileModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Middlename = user.MiddleName,
                Phone = user.Phone,
                Login = user.Login,
                History = history
            };
            return upm;
        }


    }
}
