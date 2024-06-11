using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CAKE_PROJECT_
{
   
     public class Class1
    {
        SqlCommand cmd;
        SqlConnection con;

        public Class1()
        {
            con = new SqlConnection(@"server =LAPTOP-3CFR6UM5\SQLEXPRESS; database =PROJECT1; integrated Security = True");

        }


        public int FUN_NonQuery(string sql)
        {

            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public string FUN_Scalar(string sql)
        {

            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}