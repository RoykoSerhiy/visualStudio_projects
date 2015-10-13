using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var Cassets = new List<Casset>() { 
                    new Casset(1 , "WAR Z"),
                    new Casset(2 , "Avengers"),
                    new Casset(3 , "MadMax2015"),
                };
                
                ViewState["OpenDay"] = Cassets;
                DayCloseGridView.DataSource = Cassets;//ViewState["Films"];
                DayCloseGridView.DataBind();
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            List<Casset>openday = (List<Casset>)ViewState["OpenDay"];
            foreach(Casset casset in (List<Casset>)ViewState["Films"]){
                openday.Add(casset);
            }
            DayCloseGridView.DataSource = openday;
            DayCloseGridView.DataBind();
            during_the_day.DataSource = null;
            during_the_day.DataBind();
            lblInfo.Text = "Day end";
            ViewState["Films"] = null;
            id.ReadOnly = true;
            name.ReadOnly = true;
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            List<Casset> cassets = null;
            if (ViewState["Films"] == null)
            {
                 cassets = new List<Casset>();
            }
            else
            {
                cassets = (List<Casset>)ViewState["Films"];
            }
               
              if (id.Text != "" || name.Text != "")
                {
                    cassets.Add(new Casset(Convert.ToInt32(id.Text), name.Text));
                }
            
           
            
                ViewState["Films"] = cassets;
                during_the_day.DataSource = ViewState["Films"];
                during_the_day.DataBind();
            
           
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            lblInfo.Text = "Day open";
            id.ReadOnly = false;
            name.ReadOnly = false;
        }
    }
    [Serializable]
    public class Casset
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Casset(int id , string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}