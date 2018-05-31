using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login1
{
    public partial class f_PharmacyForm : Form
    {
         public f_PharmacyForm()
        {
            InitializeComponent();
        }
        public f_PharmacyForm(int mrn,string date)
        {
             InitializeComponent();
             grid.AutoGenerateColumns = true;
             bPharmacy store = new bPharmacy();
             store.getOrders(mrn, date, grid, t_MRN, tfname, tmname, tlname, tdate);
            
                
                
           // store.getOrders(mrn, date,grid, t_MRN, tfname, tmname, tlname,tdate,grid);

        
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            f_PharmacyForm form = this;
            bPharmacy pha = new bPharmacy();
            pha.save(t_MRN, tdate, grid);

            f_PharmacyHomeScreen home = new f_PharmacyHomeScreen();
            home.Show();
            form.Close();
            //lab.saveTestResults(t_MRN, treportDate, reportGrid);
           
        }

        private void b_clear_Click(object sender, EventArgs e)
        {

        }

        private void ll_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_PharmacyForm cur = this;
            f_PharmacyHomeScreen home = new f_PharmacyHomeScreen();
            home.Show();
            this.Close();
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_PharmacyForm cur = this;
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

      /* public f_PharmacyForm(string MRN,f_PharmacyHomeScreen phm)
        {
            InitializeComponent();
            this.MRN = MRN;
            this.phm = phm;
        }

        private void f_PharmacyForm_Load(object sender, EventArgs e)
        {
            bl_pharmacy bpharm = new bl_pharmacy();
            SqlDataReader reader=bpharm.search(MRN);
            while (reader.Read())
            {
                t_MRN.Text = reader["MRN"].ToString();
                t_patientName.Text = reader["Firstname"].ToString();
                dateTimePicker1.Text = reader["Dateofvisit"].ToString();
            }
            SqlDataReader reader1 = bpharm.search(t_MRN.Text,dateTimePicker1.Text);
            while (reader1.Read())
            {
                t_nameOfMedicine1.Text = reader1["Medicine1"].ToString();
                t_nameOfMedicine2.Text = reader1["Medicine2"].ToString();
                t_nameOfMedicine3.Text = reader1["Medicine3"].ToString();
                t_nameOfMedicine4.Text = reader1["Medicine4"].ToString();
                t_nameOfMedicine5.Text = reader1["Medicine5"].ToString();
                t_nameOfMedicine6.Text = reader1["Medicine6"].ToString();
                t_nameOfMedicine7.Text = reader1["Medicine7"].ToString();
                t_nameOfMedicine8.Text = reader1["Medicine8"].ToString();
                t_nameOfMedicine9.Text = reader1["Medicine9"].ToString();
                t_nameOfMedicine10.Text = reader1["Medicine10"].ToString();
               
            }
        }
        */

      /*  private void l_dosage_Click(object sender, EventArgs e)
        {

        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            t_nameOfMedicine1.Text = "";
            t_nameOfMedicine2.Text = "";
            t_nameOfMedicine3.Text = "";
            t_nameOfMedicine4.Text = "";
            t_nameOfMedicine5.Text = "";
            t_nameOfMedicine6.Text = "";
            t_nameOfMedicine7.Text = "";
            t_nameOfMedicine8.Text = "";
            t_nameOfMedicine9.Text = "";
            t_nameOfMedicine10.Text = "";
            t_MRN.Text = "";
            t_patientName.Text = "";
            dateTimePicker1.Text = "";

        }

        private void ll_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            phm.ParentForm.Show();
        }
*/
    }
}
