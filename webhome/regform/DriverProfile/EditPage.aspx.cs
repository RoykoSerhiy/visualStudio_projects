using CodeFirst;
using regform.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.DriverProfile
{
    public partial class EditPage : MPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DriverProfile/ListPage.aspx" , false);
        }

        
        protected void ddlBody_type_Init(object sender, EventArgs e)
        {
            var ddl = sender as DropDownList;

            Array itemValues = System.Enum.GetValues(typeof(VehicleType));
            Array itemNames = System.Enum.GetNames(typeof(VehicleType));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemNames.GetValue(i).ToString(), itemValues.GetValue(i).ToString());
                ddl.Items.Add(item);
            }
        }

        protected void ddlNationality_Init(object sender, EventArgs e)
        {
            var ddl = sender as DropDownList;

            Array itemValues = System.Enum.GetValues(typeof(Nationality));
            Array itemNames = System.Enum.GetNames(typeof(Nationality));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemNames.GetValue(i).ToString(), itemValues.GetValue(i).ToString());
                ddl.Items.Add(item);
            }
        }

        protected void dsDrivers_Updating(object sender, ObjectDataSourceMethodEventArgs e)
        {
            Driver driver = e.InputParameters[0] as Driver;
            driver.Car.CarModel = extractTextBoxValue(fvEditDriver, "txtCarModel");
            driver.Car.CarBrand = extractTextBoxValue(fvEditDriver, "txtCarBrand");
            driver.Car.CarNumber = extractTextBoxValue(fvEditDriver, "txtCarNumber");
            driver.Car.CarClass = extractTextBoxValue(fvEditDriver, "txtCarClass");
            string VechileType = (fvEditDriver.FindControl("ddlBody_type") as DropDownList).SelectedValue;
            driver.Car.VehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), VechileType);
        }

       
    }
}