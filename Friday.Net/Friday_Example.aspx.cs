using Friday.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Friday.Net
{
    public partial class Friday_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            {
                CountryGetir();
            }

        }
        NorthwindEntities db = new NorthwindEntities();

        void CountryGetir()
        {

            ddlCountry.DataSource = db.Employees.ToList();
            ddlCountry.DataTextField = "Country";
            ddlCountry.DataValueField = "EmployeeID";
            ddlCountry.DataBind();

        }

        void IsciGetir(int jobID)
        {
            lstIsciler.DataSource = db.Employees.Where(x => x.EmployeeID == jobID).ToList();
            lstIsciler.DataTextField = "FirstName";
            lstIsciler.DataValueField = "EmployeeID";
            lstIsciler.DataBind();
        }


        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsciGetir(Convert.ToInt32(ddlCountry.SelectedValue));
        }
        
        protected void lstIsciler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
