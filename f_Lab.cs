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
    public partial class f_Lab : Form
    {
        public f_Lab()
        {
            InitializeComponent();
            grid.AutoGenerateColumns = true;
            bLab lab = new bLab();
            lab.displayLabOrders(grid);
            
        }

         private void button1_Click(object sender, EventArgs e)
        {
                if (grid.RowCount == 1)
                    MessageBox.Show("No Lab tests scheduled for the day!!!");
                else
                {
                    f_Lab home= this;
                    DataGridViewRow row = grid.CurrentRow;
                    string MRN =row.Cells[0].Value.ToString();
                    string date = row.Cells[2].Value.ToString();
                    int mrn = Convert.ToInt16(MRN);
                    labTest test = new labTest(mrn, date);
                    
                    
                    
                    test.Show();
                    home.Dispose();

                }
              
        }

        

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grid.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bLab lab = new bLab();
            lab.displayLabOrders(grid);
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordForm change = new changePasswordForm("Lab Technician");
            change.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bLab lab = new bLab();
            lab.conductPendingTest(grid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bLab lab = new bLab();
            lab.displayLabOrders(grid);
            
        }

        private void f_Lab_Load(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
