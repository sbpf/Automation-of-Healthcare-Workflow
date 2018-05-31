using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login1
{
    public partial class f_ScheduleAppointment : Form
    {
        public f_ScheduleAppointment()
        {
            InitializeComponent();
            slots.AutoGenerateColumns = true;
        }

      
        private void bSubmit_Click_1(object sender, EventArgs e)
        {
        
            bool status=false;
             f_ScheduleAppointment app = this;
            validationOfForms val = new validationOfForms();

             status =val.validateAppointmentForm(app,tMRN.Text, cDate.Text, cMonth.Text, cYear.Text, cHour.Text, cMinutes.Text, cAmOrPm.Text);
            if (!(status))
            {
                manAll.Show();
                manDate.Show();
                manMrn.Show();
                manTime.Show();
                MessageBox.Show("Please fill up all the required information");
            }
            
        }

        private void bCancel_Click_1(object sender, EventArgs e)
        {
        this.Dispose();
            f_ReceptionHome rec = new f_ReceptionHome();
            rec.Show();
        }

        private void bClear_Click_1(object sender, EventArgs e)
        {
            cAmOrPm.Text = "AM";
            cDate.Text ="DD";
            cMinutes.Text ="Min";
            cMonth.Text="MM";
            cYear.Text = "YYYY";
            cHour.Text="Hr";
            tMRN.Text = null;
        }

        private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            f_ReceptionHome rec = new f_ReceptionHome();
            rec.Show();
       
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Dispose();
            f_ReceptionHome rec = new f_ReceptionHome();
            rec.Show();
       
        }

        private void bReschedule_Click(object sender, EventArgs e)
        {

           /* DataGridViewRow row = slots.CurrentRow;
            dbAppointment app = new dbAppointment();
            string date = row.Cells[1].Value.ToString();
            string time = row.Cells[2].Value.ToString();

            int mrn = Convert.ToInt16(row.Cells[0].Value.ToString());
            app.editAppointment(mrn, date, time);

            slots.Hide();
            bReschedule.Visible = false;
            button2.Visible = false;
            */
            DataGridViewRow row = slots.CurrentRow;
            dbAppointment app = new dbAppointment();
            try
            {
                string date = row.Cells[1].Value.ToString();
                string time = row.Cells[2].Value.ToString();

                int mrn = Convert.ToInt16(row.Cells[0].Value.ToString());
                app.editAppointment(mrn, date, time);

                slots.Hide();
                bReschedule.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("There are no busy slots");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string date = cMonth.Text +'/'+ cDate.Text+'/'+cYear.Text;

            bAppointment b = new bAppointment();
           
            b.checkBusySlots(slots, date);
            bReschedule.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DataGridViewRow dr= slots.CurrentRow;
           string m = dr.Cells[0].Value.ToString();
           string date = dr.Cells[1].Value.ToString();
           string time = dr.Cells[2].Value.ToString();
           
           bAppointment b = new bAppointment();
           b.deleteAppointment(m,date,time);
           //slots.CurrentRow.
           MessageBox.Show("Appoinment Deleted!");
           button2.Visible = false;
           button3.Visible = false;
           slots.Hide();
           bReschedule.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            slots.Hide();
            button2.Visible = false;
            button3.Visible = false;
            bReschedule.Visible = false;
        
        }

       
    }
}



