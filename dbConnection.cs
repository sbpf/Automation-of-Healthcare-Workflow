using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;

namespace login1
{
   public  class dbConnection
    {
        public dbConnection()
        {
        }
        public SqlConnection connect()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Trusted_Connection=false;Initial Catalog=ramani; Data Source=(local);persist security info=true;User id=cerner;password=manipal@321";
            try{
            cn.Open();
            //MessageBox.Show("COonection established");
            }
           catch(Exception e)
            {
              MessageBox.Show("Connection not working",e.Message);
            }

             

                   
            return cn;
        }
        public void disconnect(SqlConnection cn)
        {
            cn.Close();
            MessageBox.Show("connection close");
        }

    }
}
