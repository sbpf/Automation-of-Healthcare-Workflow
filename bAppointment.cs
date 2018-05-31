using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace login1
{
   public  class bAppointment
    {
        public int mrn;
        public string date;
        public string time;

        public bAppointment()
        {
              mrn = 0;
              date = null;
              time = null;
        }
        public void deleteAppointment(string m,string date,string time)
        {
            dbAppointment db=new dbAppointment();
            db.deleteAppointment(m,date,time);
          

        }

        public bAppointment(string mrntext, string daytext, string monthtext, string yeartext, string hourtext, string mintext, string amorpmtext)
        {
            mrn = Convert.ToInt32(mrntext);
            date = String.Concat(monthtext, "/", daytext, "/", yeartext);
            time = string.Concat(hourtext, ":", mintext, ":", amorpmtext);
        }

        public bool scheduleAppointment()
        {
            dbAppointment app = new dbAppointment();
            if (app.storeAppointment(mrn, date, time))
                return true;
            return false;
        }
        public void checkBusySlots(DataGridView slots,string date)
        {
            //MessageBox.Show(date);
            dbAppointment d = new dbAppointment();
            DataSet ds = d.getSlots(date);
            slots.DataSource = ds.Tables["appointment"].DefaultView;
            slots.Show();
       
        }

       




    }
}

