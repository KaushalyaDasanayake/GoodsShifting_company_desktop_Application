using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace E_shift_Management_System
{
    //Create Database Connection
    class DBconnection
    {
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        public static void ExecuteQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery(); //used for executing queries
            }
        }

        //Get the data
        public static DataSet getdata(string sql)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                return ds;
            }
        }

    }
}
