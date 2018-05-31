using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.Common;

namespace login1
{
    class dbDoctor
    {
        dbConnection cn = new dbConnection();
        public DataSet displayLabTestDone (string mrn)
        {
            string str = "Select * from labtest where MRN='"+mrn+"'";
            SqlDataAdapter sd = new SqlDataAdapter(str, cn.connect());
            DataSet ds = new DataSet();
            try
            {
                sd.Fill(ds, "labtest");
            }
            catch (Exception e1)
            {
                MessageBox.Show(" The record could not be found");
            }

            return ds;


        }


        public void updateStatus(int mrn,string date)
        {
            try
            {
                string str = "Update appointment set Status='over' where MRN='" + mrn + "' and Date='" + date + "'";
                SqlCommand cmd = new SqlCommand(str, cn.connect());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("record cannot be updated");
            }

                    
        }

        public DataSet  displayMedicinePrescribed(string mrn)
        {
            string str="Select * from pharmacy where MRN='"+mrn+"'";
                 SqlDataAdapter sd = new SqlDataAdapter(str, cn.connect());
            DataSet ds = new DataSet();
            try
            {
                sd.Fill(ds, "pharmacy");
            }
            catch (Exception e1)
            {
                MessageBox.Show("The pharmacy records could not be found");
            }
          
            return ds;
        }

        public DataSet getAppointmentDetails(string today)
        {

            string strsql = "Select * from appointment where Date='" + today + "' and Status='Yet to be Treated'";
            SqlDataAdapter sd = new SqlDataAdapter(strsql, cn.connect());
            DataSet ds = new DataSet();
            try
            {
                sd.Fill(ds, "appointment");
            }
            catch (Exception e1)
            {
                MessageBox.Show("No appointments found");
            }
          
            return ds;
        }
        public DataSet displayPatientInfo(string s)
        {
            string strsql1 = "Select * from Patient_general_info where mrn='" + s + "'";
            SqlDataAdapter sd1 = new SqlDataAdapter(strsql1, cn.connect());
            DataSet ds1 = new DataSet();
            try
            {
                sd1.Fill(ds1, "Patient_general_info");
            }
            catch (Exception e)
            {
                MessageBox.Show("Patient record not found");
            }
                return ds1;
        }
        public DataSet displayProvisional(string s)
        {
            string strsql1 = "Select dateOfDiagnosis,provisionalDiagnosis  from provisional_table where mrn='" + s + "'";
            SqlDataAdapter sd1 = new SqlDataAdapter(strsql1, cn.connect());
            DataSet ds1 = new DataSet();
            try
            {
                sd1.Fill(ds1, "provisional_table");
            }
            catch (Exception e)
            {
                MessageBox.Show("No provisional diagnosis available");
            }
            return ds1;
        }
        public DataSet displayHistory(string s)
        {
            string strsql2 = "Select * from History_table where mrn='" + s + "'";
            SqlDataAdapter sd2 = new SqlDataAdapter(strsql2, cn.connect());
            DataSet ds2 = new DataSet();
            try
            {
                sd2.Fill(ds2, "History_table");
            }
            catch (Exception e2)
            {
                MessageBox.Show("History of patient could not be displayed");
            }
            return ds2;
        }
        public void saveHistory(string PI,string PI2,string KI,string KA,string FH,string m)
        {
            SqlConnection sc = cn.connect();
            string st = "update History_table set presentIllness='" + PI + "',pastIllness='"+PI2+"',familyHistory='" + FH + "',knownIllnesss='" + KI + "', knownAllergies='" + KA + "' where mrn='" + m + "'";
            SqlCommand cmd = new SqlCommand(st,sc);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e3)
            {
                MessageBox.Show("saving history failed");
            }
            MessageBox.Show("saved successfully!!");
        }
        public void savelabOrder(string m, string w, string date)
        {
            SqlConnection sc1 = cn.connect();
            int mrn = Convert.ToInt16(m);
            MessageBox.Show(m);
            string st2 = "insert into labtest values('" +mrn+ "','" + w + "','" + date + "','','Pending','','','')";
            SqlCommand cmd1 = new SqlCommand(st2, sc1);
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e4)
            {
                MessageBox.Show("Insert failed try again");
            }
            
        }
        public void saveMedPre(string m, string date, string med, int total, string no)
        {
            SqlConnection sc1 = cn.connect();
            string st2 = "insert into pharmacy values('" + m + "','" + date+ "','" + med + "','"+total+"','"+no+"')";
            SqlCommand cmd1 = new SqlCommand(st2, sc1);
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e4)
            {
                MessageBox.Show("Medicine could not be saved");
            }
          

        }
        public void saveProvisional(string m, string s, string date)
        {
            SqlConnection sc1 = cn.connect();
            string st2 = "insert into provisional_table values('" + m + "','" + s + "','" + date+ "')";
            SqlCommand cmd1 = new SqlCommand(st2, sc1);
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e4)
            {
                MessageBox.Show("Provisional Diagnosis saving failed");
            }
          
        }

    }
}