using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ass5P2
{
    public partial class Confirm : System.Web.UI.Page
    {
        Operations obj =new Operations();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds= obj.dbview();
            GridView1.DataSource = ds;
            GridView1.DataBind();

            ds = obj.dbviewW();
            GridView2.DataSource = ds;
            GridView2.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            obj.confirmuser(id);
            ds = obj.dbview();
            GridView1.DataSource = ds;
            GridView1.DataBind();

            ds = obj.dbviewW();
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
    }
}