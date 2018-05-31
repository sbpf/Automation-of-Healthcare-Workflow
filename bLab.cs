using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;


namespace login1
{
    class bLab
    {
        public bLab()
        {
        }
       
        public string getdate()
        {
            string dt;
            DateTime date = DateTime.Now;
            dt = date.ToShortDateString();
            return dt;
        }
        public void displayLabOrders(DataGridView grid)
        {
            dbLab lab=new dbLab();
            string today = getdate();
            DataSet ds = lab.getLabTestOrders(today);

            grid.DataSource = ds.Tables["labtest"].DefaultView;
           
        }
        public void conductNewTest(int mrn, string orderDate,DataGridView reportGrid,TextBox MRN,TextBox first,TextBox middle,TextBox last,TextBox date)
        {
            
            string fname,mname,lname;
             dbLab lab = new dbLab();
             DataSet ds= lab.retrieveTestsInfo(mrn, orderDate,out fname,out mname,out lname );
             reportGrid.DataSource = ds.Tables["labtest"].DefaultView;
             first.Text = fname;
             middle.Text = mname;
             last.Text = lname;
             MRN.Text = mrn.ToString();
             date.Text = getdate();
       
        }
        public void conductPendingTest(DataGridView grid)
        {

            dbLab lab = new dbLab();
            DataSet ds = lab.retrievePendingTestsDetails();
            grid.DataSource = ds.Tables["labtest"].DefaultView; 
        }


      public void saveTestResults(TextBox mrn,TextBox resultDate,DataGridView reportGrid)
    {


        bool statusFlag = false;
        bool impressionFlag = false;

        int rowcount = reportGrid.RowCount - 2;
        while (rowcount >= 0)
        {
            DataGridViewRow row = reportGrid.Rows[rowcount];
            string status = row.Cells[2].Value.ToString();
            string impression = row.Cells[5].Value.ToString();

            if (status == "Pending" || status == "Complete" || status == "retest")
                statusFlag = true;

            if (impression == "Normal" || impression == "Abnormal")
                impressionFlag = true;
            
            rowcount--;
        }
        if (!statusFlag)
            MessageBox.Show("Check for the 'Teststatus'!!\nEnter Pending or Complete");
        if (!impressionFlag)
            MessageBox.Show("Check for the 'Impression' column!!\nEnter either 'Normal' or 'Abnormal' only");

        if (statusFlag && impressionFlag)
        {
             int count = reportGrid.RowCount - 2;
             int cellsCount = reportGrid.Rows[0].Cells.Count;
              while (count >= 0)
             {
                 DataGridViewRow currentRow = reportGrid.Rows[count];
                  string testName=currentRow.Cells[0].Value.ToString();
                  string testOrderDate=currentRow.Cells[1].Value.ToString();
                  string status = currentRow.Cells[2].Value.ToString();
                  string result=currentRow.Cells[3].Value.ToString();
                  string reference=currentRow.Cells[4].Value.ToString();
                  string impression = currentRow.Cells[5].Value.ToString();

                  dbLab l=new dbLab();
                  int MRN = Convert.ToInt16(mrn.Text);
                  l.saveTestReport(MRN, testName, testOrderDate, resultDate.Text, status, result, reference, impression);
                  
                  count--;
                  //MessageBox.Show("Test Report Saved successfully!!!");
             }
              MessageBox.Show("Test Report Saved successfully!!!");
            
                
        }
 
        

    }

        /* public void conductNewTest(string mrn)
             {
                 string testDate = getdate();

                 f_LabTest labtest = new f_LabTest(mrn,testDate);//, row.ItemArray[1], row.ItemArray[2]);
                 labtest.Show();
             }*/

        /* public void conductNewTest(string mrn,string orderDate,string testOrdered)
         {
             string testDate=getdate();

             f_LabTest labtest = new f_LabTest(mrn,orderDate,testOrdered,testDate);//, row.ItemArray[1], row.ItemArray[2]);
             labtest.Show();

         }*/

  
    
    
    }

}
