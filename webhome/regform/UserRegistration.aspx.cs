using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CodeFirst;
 
namespace regform
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        public enum RegType
        {
            NotSet = -1,
            User = 0,
            Driver = 1
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void chkLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLicense.Checked)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        protected void btnSubmit_Load(object sender, EventArgs e)
        {
            if (chkLicense.Checked)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        protected void RadioButton_CheckedChanged(Object sender,
        System.EventArgs e)
        {
            if (radioUser.Checked)
            {
                multiViewUserReg.ActiveViewIndex = (int)RegType.User;
            }
            else if (radioDriver.Checked)
            {
                multiViewUserReg.ActiveViewIndex = (int)RegType.Driver;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioDriver.Checked)
            {
                Control txtName = userInfoCtrl.FindControl("txtName");
                TextBox tbName = (txtName as TextBox);
               
            }
            else
                if (radioUser.Checked)
                {
                    
                }
            
        }
        
    }
    /*public class Driver
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Middle_name { get; set; }
        int Age { get; set; }
        string Mobile_phone { get; set; }
        int License_number { get; set; }
        DateTime LN_Valid_until { get; set; }
        string Gender { get; set; }

        public Driver(string name , string surname , string middle_name, int age , 
            string phone , int lic_num , DateTime ln_valid_until , string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Middle_name = middle_name;
            this.Age = age;
            this.Mobile_phone = phone;
            this.License_number = lic_num;
            this.LN_Valid_until = ln_valid_until;
            this.Gender = gender;
        }
    }
    public class Car
    {
        string Car_brand { get; set; }
        string Car_model { get; set; }
        double Extent_engine { get; set; }
        string Body_type { get; set; }
        double Amount_of_trunk { get; set; }
        int Passanger_seats { get; set; }

        public Car(string car_brand,string car_model , double ext_engine,
            string body_type , double amount_of_trunk , int passengers_seats)
        {
            this.Car_brand = car_brand;
            this.Car_model = car_model;
            this.Extent_engine = ext_engine;
            this.Body_type = body_type;
            this.Amount_of_trunk = amount_of_trunk;
            this.Passanger_seats = passengers_seats;
        }
    }*/
}