using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ass5P2
{
    public partial class User : System.Web.UI.Page
    {
        Operations obj = new Operations();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = string.Format("{0}", Session["uid"]);
            string id = Label1.Text;
            dt=obj.empDetails(id);
            

            //Label2.Text=(string)dt.Rows[0][0];
            //Label3.Text =(string)dt.Rows[0][1];
            Label2.Text= (string)dt.Rows[0][2];
        }
    }
}