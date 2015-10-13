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
    public partial class AddPage : MPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           //dsDrivers.TypeName = typeof(Driver).AssemblyQualifiedName;
        }

        protected void btnIncert_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/DriverProfile/ListPage.aspx", false);
        }

        protected void ddlBody_type_Load(object sender, EventArgs e)
        {
            DropDownList ddl = sender as DropDownList;

            Array itemValues = System.Enum.GetValues(typeof(VehicleType));
            Array itemNames = System.Enum.GetNames(typeof(VehicleType));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemValues.GetValue(i).ToString(), itemValues.GetValue(i).ToString());
                ddl.Items.Add(item);
            }
        }

        protected void ddlNationality_Load(object sender, EventArgs e)
        {
            DropDownList ddl = sender as DropDownList;

            Array itemValues = System.Enum.GetValues(typeof(Nationality));
            Array itemNames = System.Enum.GetNames(typeof(Nationality));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemValues.GetValue(i).ToString(), itemValues.GetValue(i).ToString());
                ddl.Items.Add(item);
            }
        }

       

        protected void dsDrivers_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
        {
            Driver driver = e.InputParameters[0] as Driver;
            driver.Car.CarModel = extractTextBoxValue(fvAddDriver , "txtCarModel");
            driver.Car.CarBrand = extractTextBoxValue(fvAddDriver , "txtCarBrand");
            driver.Car.CarNumber = extractTextBoxValue(fvAddDriver, "txtCarNumber");
            driver.Car.CarClass = extractTextBoxValue(fvAddDriver,"txtCarClass");
            string VechileType =(fvAddDriver.FindControl("ddlBody_type") as DropDownList).SelectedValue;
            driver.Car.VehicleType =(VehicleType)Enum.Parse(typeof(VehicleType), VechileType);
        }
    }
}