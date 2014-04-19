using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleCloud
{
    public partial class UserData : System.Web.UI.Page
    {
        PropertyClass PS = new PropertyClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDrpCountry();
                FillUserData();
                txtcl();
            }
        }

        public void txtcl()
        {
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtemail.Text = string.Empty;
        }

        public void FillDrpCountry()
        {
            drpcountry.DataSource = PS.SelectCountry();
            drpcountry.DataTextField = "countryname";
            drpcountry.DataValueField = "countryid";
            drpcountry.DataBind();
            ListItem li = new ListItem();
            li.Text = "-- Select Country --";
            li.Value = "0";
            drpcountry.Items.Insert(0, li);
        }

        public void FillUserData()
        {
            GridView1.DataSource = PS.SelectUserData();
            GridView1.DataBind();
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            PS.FirstName = txtfname.Text;
            PS.LastName = txtlname.Text;
            PS.Email = txtemail.Text;
            PS.CountryID = Convert.ToInt16(drpcountry.SelectedItem.Value);
            PS.InsertUserData(PS);
            txtcl();
            FillUserData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillUserData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillUserData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            PS.UserID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            PS.FirstName = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            PS.LastName = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            PS.Email = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            PS.UpdataUserData(PS);
            GridView1.EditIndex = -1;
            FillUserData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PS.UserID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            PS.DeleteUserData(PS);
            FillUserData();
        }
    }
}