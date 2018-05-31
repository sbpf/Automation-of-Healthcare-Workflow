using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Drawing;

using System.Windows.Forms;


namespace login1
{
    public class dbLab
    {
       SqlConnection con; 
        public dbLab()
        {

            dbConnection cn = new dbConnection();//Establishes a connection
            con = cn.connect();//Establishes a connection
        }
        
       
        
        // a function which retrieves all the tests to be done for the day
        public DataSet getLabTestOrders(string today)
       {
                  
           
            dbConnection con = new dbConnection(); 
            string cmdString = "select mrn,TestName,TestOrderDate from labtest where TestOrderDate='"+today+"' and TestStatus='Pending'";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdString, con.connect());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "labtest");
               
            return ds;
            
       
       
       }

        public void getname(int mrn,out string fname,out string mname,out string lname)
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
        public DataSet retrieveTestsInfo(int mrn, string orderDate,out string firstName,out string middleName,out string lastName)
        {


              string f, m, l;
              getname(mrn,out f,out m,out l);
              firstName = f;
              middleName = m;
              lastName = l;

              dbConnection con = new dbConnection();
              string str = "select TestName,TestOrderDate,TestStatus,Result,Reference,Impression from labtest where TestOrderDate='"+orderDate+"' and MRN='"+mrn+"'";
              SqlDataAdapter adapter = new SqlDataAdapter(str, con.connect());
              DataSet ds = new DataSet();
              adapter.Fill(ds, "labtest");
              return ds;
        }

        public DataSet retrievePendingTestsDetails()
        {
            dbConnection con = new dbConnection();
            string cmdString = "select mrn,TestName,TestOrderDate from labtest where TestStatus='Pending '";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdString, con.connect());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "labtest");
            return ds;
            
        }

        

       public void saveTestReport(int mrn, string testName, string dateOfOrder, string dateOfConduction, string status, string result, string reference, string impression)
       {
           

           string strSQL = "Update labtest set TestConductionDate='"+dateOfConduction+"',TestStatus='"+status+"',Result='"+result+"',Reference='"+reference+"',Impression='"+impression+"' where MRN='"+mrn+"' and TestOrderDate='"+dateOfOrder+"' and TestName='"+testName+"'";

           SqlCommand cmd = new SqlCommand(strSQL, con);
           cmd.ExecuteNonQuery();
           SqlDataReader rd;

           rd = cmd.ExecuteReader();

            
        

       }
        
        public void saveTestReport(DataSet ds)
        {
        }





    }
}
