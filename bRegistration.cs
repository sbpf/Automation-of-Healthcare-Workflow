using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace login1
{
    class bRegistration 
    {
        public bRegistration()
        {

        }
        public bool register(bpatientInfo pInfo)
        {
            dbregistration dReg = new dbregistration();
            if (dReg.storePatientInfo(pInfo))
                return true;
            else
                return false;


        }

        public void openExistingRecord(int mrn)
        {
            dbregistration reg = new dbregistration();
            DataSet ds= reg.fetchRecord(mrn);
            try
            {

                DataRow drow = ds.Tables["Patient_general_info"].Rows[0];
                f_PatientDetails patient = new f_PatientDetails(drow);
                patient.Show();
            }
            catch(IndexOutOfRangeException e)
            {
                MessageBox.Show("The MRN is invalid! Enter a valid MRN");
            }

                
        }

        public bool update(bpatientInfo p)
        {

            dbregistration dReg = new dbregistration();
            if (dReg.updatePatientInfo(p))
                return true;
            else
                return false;

        }



    }
}
