using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace login1
{
    public class bPharmacy
    {
        public bPharmacy()
        {
        }
       
        
        public string getdate()
        {
            string dt;
            DateTime date = DateTime.Now;
            dt = date.ToShortDateString();
            return dt;
        }


        public void displayOrders(DataGridView grid)
        {

            dbPharmacy lab = new dbPharmacy();
            string today = getdate();
            DataSet ds = lab.getPharmacyOrders(today);
            grid.DataSource = ds.Tables["pharmacy"].DefaultView;
           
        }
        public void getOrders(int mrn, string orderDate,DataGridView grid,TextBox MRN,TextBox first,TextBox middle,TextBox last,TextBox date)
        
        {
            string fname, mname, lname;
            dbPharmacy pharma = new dbPharmacy();
            DataSet ds= pharma.retrieveOrders(mrn,orderDate,out fname, out mname, out lname);
            grid.DataSource = ds.Tables["pharmacy"].DefaultView;
            first.Text = fname;
            middle.Text = mname;
            last.Text = lname;
            MRN.Text = mrn.ToString();
            date.Text = getdate();
        
        }

        public void save(TextBox mrn, TextBox date, DataGridView grid)
        {
            int count = grid.RowCount - 2;
            int cellsCount = grid.Rows[0].Cells.Count;
           

             while (count >= 0)
            {
                DataGridViewRow currentRow = grid.Rows[count];
                
                DataGridViewRow row = grid.Rows[count];
                string Mrn = currentRow.Cells[0].Value.ToString();
                string OrderDate = currentRow.Cells[1].Value.ToString();
                string medicineName = currentRow.Cells[2].Value.ToString();
                string dosage = currentRow.Cells[3].Value.ToString();
                string status = currentRow.Cells[4].Value.ToString();
                dbPharmacy pha = new dbPharmacy();
                int MRN = Convert.ToInt16(mrn.Text);
                pha.save(MRN,OrderDate,medicineName, dosage, status);


                count--;
                // MessageBox.Show("Test Report Saved successfully!!!");

            }
             MessageBox.Show("Saved successfully!!!");

        }

    
    
    }


}
