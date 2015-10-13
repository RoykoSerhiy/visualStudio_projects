using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlExamples
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var variants = new List<string>()
                    {
                        "Show All",
                        "Show With Done Homework"
                    };

                var arrayList = new List<Student>() { 
                        new Student(1, "Igor", true),
                        new Student(2, "Ne Igor", false),
                        new Student(3, "Naverno Igor", false),
                        new Student(4, "A mozhet i da", true)
                };

                repeater.DataSource = arrayList;
                repeater.DataBind();

                drop1.DataSource = variants;
                mygrid.DataSource = arrayList;

                drop1.DataBind();

                ViewState["students"] = arrayList;
            }
            mygrid.DataBind();
            
        }

        protected void drop1_TextChanged(object sender, EventArgs e)
        {
            DropDownList drop = (DropDownList)sender;
            List<Student> students = (List<Student>)ViewState["students"];
            if (drop.SelectedValue == "Show With Done Homework") { 
                students = students.Where(x => x.DoneHomeWork == true).ToList();
                mygrid.DataSource = students;
                mygrid.DataBind();
            }
            else
            {
                mygrid.DataSource = students;
                //mygrid.DataBind();
            }
        }


        //[System.Web.Services.WebMethod]
        //[System.Web.Script.Services.ScriptMethod]
        //public string[] GetCompletionList(string prefixText, int count)
        //{
        //    return new string[] { "one", "two", "three" };
        //}

    }



    [Serializable]
    public class Student
    {
        public Student(int Id, string Name, Boolean DoneDz)
        {
            this.Id = Id;
            this.Name = Name;
            this.DoneHomeWork = DoneDz;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean DoneHomeWork { get; set; }
    }
}