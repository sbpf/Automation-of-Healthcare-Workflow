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
    public partial class f_DoctorHome : Form
    {
        bDoctor bd = new bDoctor();
        public f_DoctorHome()
        {
            InitializeComponent();
            bd.getAppointmentDetails(dataGridView1);
        }

        private void f_DoctorHome_Load(object sender, EventArgs e)
        {

        }

        private void Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons b_yes = new MessageBoxButtons();
            this.Dispose();
            MessageBox.Show("Are you sure u want to logout?", "Logout", b_yes);
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sr;
         
                DataGridViewRow row = dataGridView1.CurrentRow;
               
                sr = row.Cells[0].Value.ToString();
               
                 bd.getPatientInfoHistory(sr);
                // bd.displayLabTestDone(sr);
                 //bd.displayMedicinePrescribed(sr);

                     
            //bd.openmrn(sr);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordForm change = new changePasswordForm("Doctor");
            change.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
