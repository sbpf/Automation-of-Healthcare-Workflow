using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public bAppointment(string mrntext, string daytext, string monthtext, string yeartext, string hourtext, string mintext, string amorpmtext)
        {
            mrn = Convert.ToInt32(mrntext);
            date = String.Concat(daytext, "/", monthtext, "/", yeartext);
            time = string.Concat(hourtext, ":", mintext, ":", amorpmtext);
        }

       public void scheduleAppointment()
       {
          
       }


    }
}

