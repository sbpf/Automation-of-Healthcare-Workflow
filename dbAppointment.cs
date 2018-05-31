using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
namespace login1
{
    class dbAppointment
    {
        SqlConnection con;

        public dbAppointment()
        {
            dbConnection cn = new dbConnection();//Establishes a connection
            con = cn.connect();//Establishes a connection

        }
        public void deleteAppointment(string m,string date,string time)
        {
            try
            {

                string st = "delete from appointment where mrn='" + m + "' and date='" + date + "'and time='" + time + "'";

                SqlCommand cmd1 = new SqlCommand(st, con);
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("The appointment could not be deleted. Try again.");
            }

        }
        public bool  checkMrn(string mrn)
        {
            try
            {
                string st = "select * from Patient_general_info where mrn='"+mrn+"'";
                SqlCommand cmd = new SqlCommand(st, con);
                SqlDataReader rd;
                
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {

                    return true;
                }

                else 
                    return false;
                    
            }
            catch (Exception e)
            {
                
                    return false;

            }
        }




        public DataSet getSlots(string date)
        {
            string strsql = "Select * from appointment where Date='" + date + "'";
            SqlDataAdapter sd = new SqlDataAdapter(strsql, con);
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
        public void editAppointment(int mrn, string date, string time)
        {
            try
            {

                string str = "update appointment set date='" + date + "',time='" + time + "' where mrn='" + mrn + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
            }
            catch (Exception e)
            {
                MessageBox.Show("Appointment not saved.. Try again");
            }

        }


        public bool storeAppointment(int m, string d, string t)
        {
            try
            {
                string strSQL1 = "select time from appointment where date='" + d + "' and time='" + t + "'";

                // string strSQL1="select time from appointment where time in(select time from appointment 
                string strSQL2 = "Insert into appointment values('" + m + "', '" + d + "','" + t + "','Yet to be treated')";

                

                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);


                SqlDataReader rd;
                rd = cmd1.ExecuteReader();


                 if (!(rd.Read()))
                {
                    rd.Close();
                    cmd2.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception e)
            {
                MessageBox.Show("Appointment not stored..Please try again");
                return false;
            }
            //finally
            //{
                //dbConnection cn = new dbConnection();//Disconnect a connection
               // cn.disconnect();
               
            //}
            //}
            //return false;

        }
    }
}

