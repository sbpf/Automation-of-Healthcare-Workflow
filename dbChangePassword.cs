using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace login1
{
   public class dbChangePassword
    {
       SqlConnection con;
       public dbChangePassword()
       {
           //SqlConnection con;       
            
            dbConnection cn = new dbConnection();//Establishes a connection
            con= cn.connect();//Establishes a connection
           
        
       }
       public bool passwordChangeCheck(string role, string oldPassword, string newPassword)
       {
           try
           {
               string strSQL1 = "Update login1 set password='" + newPassword + "' where password in( Select password From login1 where role='" + role + "'and password='" + oldPassword + "')";
               string strSQL2 = "Select password From login1 where role='" + role + "'";


               SqlCommand cmd1 = new SqlCommand(strSQL1, con);
               SqlCommand cmd2 = new SqlCommand(strSQL2, con);
               SqlDataReader rd2;

               rd2 = cmd2.ExecuteReader();


               while (rd2.Read())
               {

                   if (oldPassword == rd2.GetString(rd2.GetOrdinal("password")))
                   {
                       rd2.Close();

                       cmd1.ExecuteNonQuery();



                       return true;

                   }

                   else
                   {

                       return false;



                   }

               }


               return false;
           }
           catch (Exception e)
           {
               MessageBox.Show("Password change failed!!Try ");
               return false;
           }
           /*finally
           {
               dbConnection cn = new dbConnection();
              // cn.disconnect(cn);
               return false;
           }*/

           
       }


    }
}
