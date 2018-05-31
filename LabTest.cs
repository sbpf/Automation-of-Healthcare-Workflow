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
    public partial class  labTest : Form
    {
        public labTest()
        {
            InitializeComponent();
        }

        public labTest(int mrn, string orderDate)
        {
            InitializeComponent();
            reportGrid.AutoGenerateColumns = true;
            bLab lab = new bLab();
            lab.conductNewTest(mrn, orderDate,reportGrid,t_MRN,tfname,tmname,tlname,treportDate);
           
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void l_nameOfMedicine_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labTest form = this;
           bLab lab = new bLab();
           lab.saveTestResults(t_MRN,treportDate,reportGrid);
           //this.Dispose();
           f_Lab home = new f_Lab();
           home.Show();
           form.Close();

        }

        private void ll_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            f_Lab home = new f_Lab();
            home.Show();
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.Show(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
              f_Lab home = new f_Lab();
            home.Show();
        

        }

        private void reportGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
