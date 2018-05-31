using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Windows.Forms;



namespace login1
{
    public class dbPharmacy
    {
        SqlConnection con; 
        public dbPharmacy()
        {
            dbConnection cn = new dbConnection();//Establishes a connection
            con = cn.connect();//Establishes a connection
       
        }


        public DataSet getPharmacyOrders(string date)
        {


            dbConnection con = new dbConnection();
            string cmdString = "select * from pharmacy where VisitDate='" + date + "'and DispenseStatus='no'";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdString, con.connect());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "pharmacy");

            return ds;

        }
       
        
        public void getname(int mrn, out string fname, out string mname, out string lname)
        {
            fname = "";
            mname = "";
            lname = "";


            string strSQL = "Select P_firstName,P_middleName,P_lastName from Patient_general_info where mrn='" + mrn + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                fname = rd.GetString(rd.GetOrdinal("P_firstName"));
                mname = rd.GetString(rd.GetOrdinal("P_middleName"));
                lname = rd.GetString(rd.GetOrdinal("P_lastName"));
            }

        }





        //a function to retrieve the list of tests ordered for a 
        //particular patient on a particular visit date
        public DataSet retrieveOrders(int mrn, string orderDate, out string firstName, out string middleName, out string lastName)
        {


            string f, m, l;
            getname(mrn, out f, out m, out l);
            firstName = f;
            middleName = m;
            lastName = l;

            dbConnection con = new dbConnection();
           // MessageBox.Show(Convert.ToString(mrn));
           // MessageBox.Show(orderDate);
            string str = "select * from pharmacy where VisitDate='" + orderDate + "' and MRN='" + mrn + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(str, con.connect());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "pharmacy");
           // MessageBox.Show("y");
            
            return ds;
        }

        public void save(int MRN,string OrderDate,string medicineName,string dosage,string status)
        {
            string strSQL = "Update pharmacy set DispenseStatus='"+status+"' where MRN='" + MRN + "' and VisitDate='" + OrderDate + "' and MedicineName='"+medicineName+"'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            SqlDataReader rd;

            rd = cmd.ExecuteReader();

        }

    }
}
