using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApplication_ThreeLayer
{
    public partial class UserInsert : System.Web.UI.Page
    {
        InsertCLS objbll = new InsertCLS();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photoss/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            int i = objbll.insertFn(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text,p, TextBox4.Text, TextBox5.Text);
            if (i != 0)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}