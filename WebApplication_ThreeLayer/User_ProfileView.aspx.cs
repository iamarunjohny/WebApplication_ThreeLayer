using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication_ThreeLayer
{
    public partial class User_ProfileView : System.Web.UI.Page
    {
        ProfileCLS objbll = new ProfileCLS();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = objbll.fun_GetData(uid);
            while (dr.Read())
            {

                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

            DataSet ds = objbll.fun_GetData_Dataset(uid);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}