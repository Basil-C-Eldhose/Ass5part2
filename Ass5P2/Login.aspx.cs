using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Ass5P2
{
    public partial class Login : System.Web.UI.Page
    {
        Operations obj = new Operations();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="admin" && TextBox2.Text=="admin")
            {
                Response.Redirect("Confirm.aspx");
            }
            dt=obj.test("select * from login where uname='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "' and state='confirmed'");
            if(dt.Rows.Count > 0)
            {
                Session["user"] = TextBox1.Text;
                Session["uid"] = dt.Rows[0][0];
                Response.Write("Valid user");
                Response.Redirect("User.aspx");
            }
            TextBox1.Text = "";
            TextBox2.Text = "";


        }
    }
}