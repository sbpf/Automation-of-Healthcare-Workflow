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
    public partial class f_PharmacyHomeScreen : Form
    {
      
        public f_PharmacyHomeScreen()
        {
             InitializeComponent();
            infodetailtable.AutoGenerateColumns = true;
            bPharmacy store = new bPharmacy();
            store.displayOrders(infodetailtable);

        }

        private void b_DispenseMedicine_Click(object sender, EventArgs e)
        {
            //if (grid.RowCount == 1)
             //   MessageBox.Show("No Lab tests scheduled for the day!!!\nEnter an MRN to perform a lab test");
            //else
           // {
                f_PharmacyHomeScreen home = this;

                DataGridViewRow row = infodetailtable.CurrentRow;
                string MRN = row.Cells[0].Value.ToString();
                string date = row.Cells[1].Value.ToString();
                int mrn = Convert.ToInt16(MRN);
                f_PharmacyForm med = new f_PharmacyForm(mrn,date);

                med.Show();
                home.Dispose();

            //}
        }

        private void b_ChangePassword_Click(object sender, EventArgs e)
        {
            changePasswordForm change = new changePasswordForm("Pharmacist");
            change.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordForm change = new changePasswordForm("Pharmacist");
            change.Show();
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_PharmacyHomeScreen cur=this;
            Form1 form=new Form1();
            form.Show();
            this.Close();

        }

   
    }
}
