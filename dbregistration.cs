using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;


namespace login1
{
    class dbregistration
    {
        SqlConnection con;   
        public dbregistration()
        {
            dbConnection cn = new dbConnection();//Establishes a connection
            con = cn.connect();//Establishes a connection

        }


        public DataSet fetchRecord(int mrn)
        {
            string strsql1 = "Select * from Patient_general_info where mrn='" +mrn+ "'";
            SqlDataAdapter sd1 = new SqlDataAdapter(strsql1, con);
            DataSet ds1 = new DataSet();
            try
            {
                sd1.Fill(ds1, "Patient_general_info");
            }
            catch (Exception e)
            {
                MessageBox.Show("The MRN is invalid! Enter a valid MRN!");
                
            }
            return ds1;
        }

        public bool storePatientInfo(bpatientInfo patient)
        {

            string strSQL = "Insert into Patient_general_info values('" + patient.firstName + "', '" + patient.middleName + "','" + patient.lastName + "', '" + patient.fatherName + "','" + patient.occupation + "','" + patient.office + "','" + patient.religion + "','" + patient.ethnicity + "' ,'" + patient.streetAddress2 + "','" + patient.city2 + "','" + patient.state2 + "','" + patient.zipcode2 + "','" + patient.streetAddress3 + "','" + patient.city3 + "','" + patient.state3 + "','" + patient.zipcode3 + "','" + patient.phoneHomeCode + "','" + patient.phoneOfficeCode + "','" + patient.phoneMobileCode + "','" + patient.phoneHome + "','" + patient.phoneOffice + "','" + patient.phoneMobile + "','" + patient.email + "','" + patient.eFirstName + "','" + patient.eMiddleName + "','" + patient.eLastName + "','" + patient.eHomestreet + "','" + patient.eHomeCity + "','" + patient.eHomeState + "','" + patient.eHomeZip + "','" + patient.eOfficeStreet + "','" + patient.eOfficeCity + "','" + patient.eOfficeState + "','" + patient.eOfficeZip + "','" + patient.eHomePhoneCode + "','" + patient.eOfficePhoneCode + "','" + patient.eMobilePhoneCode + "','" + patient.ePhoneHome + "','" + patient.ePhoneOffice + "','" + patient.ePhoneMobile + "' ,'"+patient.eEmail+"','"+patient.dob+"','"+patient.gender+"')";//select SCOPE_IDENTITY()";
      //    string str = "select mrn from Patient_general_info where P_firstName='" + patient.firstName + "'and P_middleName='" + patient.middleName + "' and P_lastName='" + patient.lastName + "'";

           string cmdstr = "select SCOPE_IDENTITY()";
           SqlCommand cmd = new SqlCommand(strSQL, con);
           cmd.ExecuteNonQuery();
           
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmdstr, con);
           DataSet ds = new DataSet();
           adapter.Fill(ds);
           string sindhu=ds.Tables[0].Rows[0].ItemArray[0].ToString();
           int s = Convert.ToInt16(sindhu);
           MessageBox.Show("This is the new MRN for the patient:"+sindhu);

           string st1 = "Insert into History_table values('" + s + "','','','','','')";
           SqlCommand cmd1 = new SqlCommand(st1, con);
           cmd1.ExecuteNonQuery();

         
            return true;

        }

        public bool updatePatientInfo(bpatientInfo patient)
        {
            string mrnstr = Convert.ToString(patient.mrn);
            MessageBox.Show(mrnstr);
            string strSQL = "update  Patient_general_info set P_firstName='" + patient.firstName + "', P_middleName='" + patient.middleName + "', P_lastName='" + patient.lastName + "',P_relativeName= '" + patient.fatherName + "', P_occupation='" + patient.occupation + "', P_office='" + patient.office + "',P_religion='" + patient.religion + "',P_ethinicity='" + patient.ethnicity + "' ,P_HstreetAddress='" + patient.streetAddress2 + "',P_Hcity='" + patient.city2 + "',P_Hstate='" + patient.state2 + "',P_HzipCode='" + patient.zipcode2 + "',P_OstreetAddress='" + patient.streetAddress3 + "',P_Ocity='" + patient.city3 + "',P_Ostate='" + patient.state3 + "',P_OzipCode='" + patient.zipcode3 + "',P_Hcode='" + patient.phoneHomeCode + "',P_Ocode='" + patient.phoneOfficeCode + "',P_Mcode='" + patient.phoneMobileCode + "',P_Hphone='" + patient.phoneHome + "',P_Ophone='" + patient.phoneOffice + "',P_Mphone='" + patient.phoneMobile + "',P_email='" + patient.email + "',P_emerFirstName='" + patient.eFirstName + "',P_emerMiddleName='" + patient.eMiddleName + "',P_emerLastName='" + patient.eLastName + "',P_emerHstreetAddress='" + patient.eHomestreet + "',P_emerHcity='" + patient.eHomeCity + "',P_emerHstate='" + patient.eHomeState + "',P_emerHzipcode='" + patient.eHomeZip + "',P_emerOstreetAddress='" + patient.eOfficeStreet + "',P_emerOcity='" + patient.eOfficeCity + "',P_emerOState='" + patient.eOfficeState + "',P_emerOzipcode='" + patient.eOfficeZip + "',P_emerHcode='" + patient.eHomePhoneCode + "',P_emerOcode='" + patient.eOfficePhoneCode + "',P_emerMcode='" + patient.eMobilePhoneCode + "',P_emerHphone='" + patient.ePhoneHome + "',P_emerOphone='" + patient.ePhoneOffice + "',P_emerMphone='" + patient.ePhoneMobile + "',P_dob='"+patient.dob+"',P_gender='"+patient.gender+"' where mrn='" + patient.mrn + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            return true;
           
     
        }





    }
}
