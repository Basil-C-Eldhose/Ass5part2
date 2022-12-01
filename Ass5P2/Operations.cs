using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ass5P2
{
    public class Operations
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd= new SqlCommand();

        public Operations()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=Ass3Emp;Integrated Security=True;pooling=false";
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void insertdb(string sql)
        {
            Getcon();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText=sql;
            cmd.ExecuteNonQuery();
        }
        public DataTable test(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet dbview()
        {
            string s = "select * from login where state='not confirmed'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }

        public DataSet dbviewW()
        {
            string s = "select * from login where state='confirmed'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        public void confirmuser(string id)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            string sql = "update login set state='confirmed' where lid='" + id + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            

        }
        public DataTable empDetails(string id)
        {
            string sql = "select * from userreg where uid='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}