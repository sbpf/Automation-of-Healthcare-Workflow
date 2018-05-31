using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace login1
{
    class bDoctor
    {
        dbDoctor d = new dbDoctor();
        public string getToday()// To get system date
        {
            string dt;
            DateTime date = DateTime.Now;
            dt = date.ToShortDateString();
            return dt;

        }
        public void getAppointmentDetails(DataGridView gd)
        {
            string today = getToday();
           
            DataSet ds = d.getAppointmentDetails(today);
            gd.DataSource = ds.Tables["appointment"].DefaultView;
        }

        public void setAppointmentStatus(int mrn, string date)
        {
            d.updateStatus(mrn, date);
        }

        public void getPatientInfoHistory(string mrn)
        {
            //Display Patient Details
            f_PatientDetails fd = new f_PatientDetails(mrn);
            DataSet ds = d.displayPatientInfo(mrn);
            DataRow drow = ds.Tables["Patient_general_info"].Rows[0];
       
            //Display History Details
            DataSet ds1 = d.displayHistory(mrn);
            DataRow drow1 = ds1.Tables["History_table"].Rows[0];

            DataSet ds2 = new DataSet();
               ds2= d.displayLabTestDone(mrn);
            
            DataSet ds3 = d.displayMedicinePrescribed(mrn);

            DataSet ds4 = d.displayProvisional(mrn);
           // MessageBox.Show("hello");

            fd.setTextField(drow, drow1,  ds2,  ds3,  ds4);
            
            fd.Show();
            
        }
        public void saveHistory(string PI,string PI2,string KI,string KA,string FH,string mrn)
        {
            d.saveHistory(PI,PI2,KI,KA,FH,mrn);
        }
        public void savelabOrder(string m, string w, string date)
        {
            d.savelabOrder(m, w, date);
        }
        public int calculateTotalDosage(int m ,int noon,int n,int days)
        {
         int   total=(m+noon+n)*days;
            return total;
        }
        public void saveMedicinePrescribed(string m, string date, string med, int total, string no)
        {
            d.saveMedPre(m, date, med, total, no);
            MessageBox.Show(" medicines saved!!");
        }
        public void saveProvisional(string m, string s, string date)
        {
            d.saveProvisional(m, s, date);

        }
     /*  public void  displayLabTestDone( DataGridView dataGridView1,string mrn)
       {
           
       }
        public void displayMedicinePrescribed( DataGridView dataGridView3,string mrn)
        {
            DataSet ds=d.displayMedicinePrescribed(mrn);
            dataGridView3.DataSource = ds.Tables["pharmacy"].DefaultView;
        }

        public void displayProvisionalDiagnosis(DataGridView gd)
        { 
        }*/
    }

}
