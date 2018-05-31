using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace login1
{
    class dbLogin
    {
        SqlConnection con;        
        
       
        public dbLogin()
        {
            dbConnection cn = new dbConnection();//Establishes a connection
            con= cn.connect();//Establishes a connection
           
        }
        public bool loginCheck( string role, string uname, string password)
        {
            string strSQL = "Select username,password From login1 where role='" + role + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            //DateTime date = DateTime.Now;
            
            //rd.
            while (rd.Read())
            {

                if ((uname == rd.GetString(rd.GetOrdinal("username"))) && (password == rd.GetString(rd.GetOrdinal("password"))))
                {
                    return true;
                    
                }

                else
                {
                  
                    return false;
                   

                }
            }
            return false;
        }
    }
}
