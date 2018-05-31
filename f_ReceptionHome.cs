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
    public partial class f_ReceptionHome : Form
    {
        public f_ReceptionHome()
        {
            InitializeComponent();
        }

        private void b_RegisterPatient_Click(object sender, EventArgs e)
        {
           

            f_PatientDetails pReg = new f_PatientDetails();
            pReg.Show();
        }

       /* private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_ChangePassword aobj = new f_ChangePassword();
            aobj.Show();
        }*/


        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //appointment_form app = new appointment_form();
            //app.Show();
            f_ScheduleAppointment aobj = new f_ScheduleAppointment();
            aobj.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void l_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           MessageBoxButtons b_yes = new MessageBoxButtons();
           MessageBox.Show("Are you sure u want to logout?", "Logout", b_yes);
            this.Dispose();
            Form1 login = new Form1();
          
            login.Show();
        }

        private void l_changepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordForm change = new changePasswordForm("Receptionist");
            change.Show();

        }

        private void b_SearchPatient_Click(object sender, EventArgs e)
        {
            option.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int mrn = Convert.ToInt16(textBox1.Text);
                textBox1.Text = "";
                option.Hide();
                bRegistration obj = new bRegistration();
                obj.openExistingRecord(mrn);
            }
            else
                MessageBox.Show("Enter the MRN");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            option.Hide();
        }

       
    }
}
