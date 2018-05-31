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
    public partial class f_PatientDetails : Form
    {
        string m;
        public f_PatientDetails()
        {
            InitializeComponent();
            tabPresentDiagnosis.Dispose();
            tabPastDiagnosis.Dispose();
            tabHistory.Dispose();
           // tb_mrn.Enabled = false;
        }
        
        
        //For the receptionist to edit the patient details
        public f_PatientDetails(DataRow drow)
        {
            InitializeComponent();
            tabPresentDiagnosis.Dispose();
            tabPastDiagnosis.Dispose();
            tabHistory.Dispose();
            bSaveChanges.Show();

           // bSave.Visible = false;
            bSave1.Visible = false;
            bClear1.Visible = false;
            bclear.Visible = false;


            tb_mrn.Text = drow.ItemArray.GetValue(0).ToString();
            tFirstName.Text = drow.ItemArray.GetValue(1).ToString();
            tMiddleName.Text = drow.ItemArray.GetValue(2).ToString();
            tLastName.Text = drow.ItemArray.GetValue(3).ToString();


            tFatherName.Text = drow.ItemArray.GetValue(4).ToString();
            
            string gender = drow.ItemArray.GetValue(43).ToString();
            if (gender == "Male")
                rbMale.Select();
            else
                rbFemale.Select();
           // patient.mrn = Convert.ToInt32(tb_mrn.Text);

            cDay.Visible = false;
            cMonth.Visible = false;
            cYear.Visible = false;

            dob.Visible = true;
            dob.Text = drow.ItemArray.GetValue(42).ToString();
            
            tOccupation.Text = drow.ItemArray.GetValue(5).ToString();
            tOffice.Text = drow.ItemArray.GetValue(6).ToString();
            cReligion.Text = drow.ItemArray.GetValue(7).ToString();
            tEthnicity.Text = drow.ItemArray.GetValue(8).ToString();
            tEmail.Text = drow.ItemArray.GetValue(23).ToString();


            tStreetAddress2.Text = drow.ItemArray.GetValue(9).ToString();

            tCity2.Text = drow.ItemArray.GetValue(10).ToString();

            tState2.Text = drow.ItemArray.GetValue(11).ToString();
            tZipCode2.Text = drow.ItemArray.GetValue(12).ToString();

            tStreetAddress3.Text = drow.ItemArray.GetValue(13).ToString();
            tCity3.Text = drow.ItemArray.GetValue(14).ToString();
            tState3.Text = drow.ItemArray.GetValue(15).ToString();
            tZipCode3.Text = drow.ItemArray.GetValue(16).ToString();


            tHomePhoneCode.Text = drow.ItemArray.GetValue(17).ToString();
            tOfficePhoneCode.Text = drow.ItemArray.GetValue(18).ToString();
            tMobileCode.Text = drow.ItemArray.GetValue(19).ToString();
            tHomePhone.Text = drow.ItemArray.GetValue(20).ToString();
            tMobilePhone.Text = drow.ItemArray.GetValue(22).ToString();
            tOfficePhone.Text = drow.ItemArray.GetValue(21).ToString();


         tEmail1.Text = drow.ItemArray.GetValue(41).ToString();
            tFirstName1.Text = drow.ItemArray.GetValue(24).ToString();
            tMiddleName1.Text = drow.ItemArray.GetValue(25).ToString();
            tLastName1.Text = drow.ItemArray.GetValue(26).ToString();
            tStreetAddress.Text = drow.ItemArray.GetValue(27).ToString();
            tCity.Text = drow.ItemArray.GetValue(28).ToString();
            tState.Text = drow.ItemArray.GetValue(29).ToString();
            tZipCode.Text = drow.ItemArray.GetValue(30).ToString();
            tStreetAddress1.Text = drow.ItemArray.GetValue(31).ToString();
            tCity1.Text = drow.ItemArray.GetValue(32).ToString();
            tState1.Text = drow.ItemArray.GetValue(33).ToString();
            tZipCode1.Text = drow.ItemArray.GetValue(34).ToString();
            tHomePhone1.Text = drow.ItemArray.GetValue(35).ToString();
            tOfficePhoneCode1.Text = drow.ItemArray.GetValue(36).ToString();
            tMobileCode.Text = drow.ItemArray.GetValue(37).ToString();
            tHomePhone.Text = drow.ItemArray.GetValue(38).ToString();
            tOfficePhone1.Text = drow.ItemArray.GetValue(39).ToString();
            tMobilePhone1.Text = drow.ItemArray.GetValue(40).ToString();
            
            tb_mrn.Visible = true;
            tb_mrn.ReadOnly = true;
         

        }

        public f_PatientDetails(string mrn)//Disabling edit option of general information for doctor
        {
            InitializeComponent();
            //dataGridView5.AutoGenerateColumns = true;
            medGrid.AutoGenerateColumns = true;
            Labgrid.AutoGenerateColumns = true;

            m = mrn;
            tFirstName.Enabled = false;
            tMiddleName.Enabled = false;
            tLastName.Enabled = false;


            tFatherName.Enabled = false;
            tOccupation.Enabled = false;

            //patient.mrn = Convert.ToInt32(tMrn.Text);
            tOffice.Enabled = false;
            cReligion.Enabled = false;
            tEthnicity.Enabled = false;
            tEmail.Enabled = false;


            tStreetAddress2.Enabled = false;

            tCity2.Enabled = false;

            tState2.Enabled = false;
            tZipCode2.Enabled = false;

            tStreetAddress3.Enabled = false;
            tCity3.Enabled = false;
            tState3.Enabled = false;
            tZipCode3.Enabled = false;


            tHomePhoneCode.Enabled = false;
            tOfficePhoneCode.Enabled = false;
            tMobileCode.Enabled = false;
            tHomePhone.Enabled = false;
            tMobilePhone.Enabled = false;
            tOfficePhone.Enabled = false;


            tEmail1.Enabled = false;
            tFirstName1.Enabled = false;
            tMiddleName1.Enabled = false;
            tLastName1.Enabled = false;
            tStreetAddress.Enabled = false;
            tCity.Enabled = false;
            tState.Enabled = false;
            tZipCode.Enabled = false;
            tStreetAddress1.Enabled = false;
            tCity1.Enabled = false;
            tState1.Enabled = false;
            tZipCode1.Enabled = false;
            tHomePhone1.Enabled = false;
            tOfficePhoneCode1.Enabled = false;
            tMobileCode.Enabled = false;
            tHomePhone.Enabled = false;
            tOfficePhone1.Enabled = false;
            tMobilePhone1.Enabled = false;
        //    bDoctor bd=new bDoctor();
         //   bd.getPatientInfoHistory(m);
           // bd.displayLabTestDone(dataGridView1, m);
           // bd.displayMedicinePrescribed(dataGridView3, m);


        }

        public void setTextField(DataRow drow, DataRow drow1, DataSet ds1, DataSet ds2, DataSet ds3)// Displaying fields retrived from database
        {
            tFirstName.Text = drow.ItemArray.GetValue(1).ToString();
            tMiddleName.Text = drow.ItemArray.GetValue(2).ToString();
            tLastName.Text = drow.ItemArray.GetValue(3).ToString();


            tFatherName.Text = drow.ItemArray.GetValue(4).ToString();
            tb_mrn.Text = drow.ItemArray.GetValue(0).ToString();
           
         
            string gender = drow.ItemArray.GetValue(43).ToString();
            if (gender == "Male")
                rbMale.Select();
            else
                rbFemale.Select();
            //patient.mrn = Convert.ToInt32(tMrn.Text);
            tOffice.Text = drow.ItemArray.GetValue(6).ToString();
            cReligion.Text = drow.ItemArray.GetValue(7).ToString();
            tEthnicity.Text = drow.ItemArray.GetValue(8).ToString();
            tEmail.Text = drow.ItemArray.GetValue(23).ToString();


            tStreetAddress2.Text = drow.ItemArray.GetValue(9).ToString();

            tCity2.Text = drow.ItemArray.GetValue(10).ToString();

            tState2.Text = drow.ItemArray.GetValue(11).ToString();
            tZipCode2.Text = drow.ItemArray.GetValue(12).ToString();

            tStreetAddress3.Text = drow.ItemArray.GetValue(13).ToString();
            tCity3.Text = drow.ItemArray.GetValue(14).ToString();
            tState3.Text = drow.ItemArray.GetValue(15).ToString();
            tZipCode3.Text = drow.ItemArray.GetValue(16).ToString();


            tHomePhoneCode.Text = drow.ItemArray.GetValue(17).ToString();
            tOfficePhoneCode.Text = drow.ItemArray.GetValue(18).ToString();
            tMobileCode.Text = drow.ItemArray.GetValue(19).ToString();
            tHomePhone.Text = drow.ItemArray.GetValue(20).ToString();
            tMobilePhone.Text = drow.ItemArray.GetValue(21).ToString();
            tOfficePhone.Text = drow.ItemArray.GetValue(22).ToString();


            tEmail1.Text = drow.ItemArray.GetValue(23).ToString();
            tFirstName1.Text = drow.ItemArray.GetValue(24).ToString();
            tMiddleName1.Text = drow.ItemArray.GetValue(25).ToString();
            tLastName1.Text = drow.ItemArray.GetValue(26).ToString();
            tStreetAddress.Text = drow.ItemArray.GetValue(27).ToString();
            tCity.Text = drow.ItemArray.GetValue(28).ToString();
            tState.Text = drow.ItemArray.GetValue(29).ToString();
            tZipCode.Text = drow.ItemArray.GetValue(30).ToString();
            tStreetAddress1.Text = drow.ItemArray.GetValue(31).ToString();
            tCity1.Text = drow.ItemArray.GetValue(32).ToString();
            tState1.Text = drow.ItemArray.GetValue(33).ToString();
            tZipCode1.Text = drow.ItemArray.GetValue(34).ToString();
            tHomePhone1.Text = drow.ItemArray.GetValue(35).ToString();
            tOfficePhoneCode1.Text = drow.ItemArray.GetValue(36).ToString();
            tMobileCode.Text = drow.ItemArray.GetValue(37).ToString();
            tHomePhone.Text = drow.ItemArray.GetValue(38).ToString();
            tOfficePhone1.Text = drow.ItemArray.GetValue(39).ToString();
            tMobilePhone1.Text = drow.ItemArray.GetValue(40).ToString();

            cDay.Visible = false;
            cMonth.Visible = false;
            cYear.Visible = false;

            dob.Visible = true;
            dob.Text = drow.ItemArray.GetValue(42).ToString();
            tb_mrn.Visible = true;
            bSave1.Visible = false;
            bClear1.Visible = false;
           // bSave.Visible = false;
            bclear.Visible = false;
             rtPresentIllness.Text ="";
            rtPastIllness.Text = drow1.ItemArray.GetValue(2).ToString();
            rtFamilyHistory.Text = drow1.ItemArray.GetValue(3).ToString();
            rtKnownAllergies.Text = drow1.ItemArray.GetValue(5).ToString();
            rtKnownIllness.Text = drow1.ItemArray.GetValue(4).ToString();
            tb_mrn.ReadOnly = true;
            past.DataSource = ds3.Tables["provisional_table"].DefaultView;
            Labgrid.DataSource = ds1.Tables["labtest"].DefaultView;
 
            medGrid.DataSource = ds2.Tables["pharmacy"].DefaultView;
          


            // rtKnownIllness.Text = drow1.ItemArray.GetValue(3).ToString();
            //rtKnownAllergies.Text = drow1.ItemArray.GetValue(4).ToString();

            //   rtFamilyHistory.Text = drow.ItemArray.GetValue(5).ToString();
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons b_yes = new MessageBoxButtons();
            MessageBox.Show("Are you sure u want to logout?", "Logout", b_yes);
            this.Close();
            f_DoctorHome login = new f_DoctorHome();
            login.Show();
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }

        private void bSave1_Click(object sender, EventArgs e)
        {

        }

        private void ll_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_PatientDetails current = this;

            f_ReceptionHome rec = new f_ReceptionHome();
            rec.Show();
            this.Dispose();

        }

        private void f_PatientDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ramaniDataSet.labRequest' table. You can move, or remove it, as needed.
          //  this.labRequestTableAdapter.Fill(this.ramaniDataSet.labRequest);
            // TODO: This line of code loads data into the 'ramaniDataSet.labtest' table. You can move, or remove it, as needed.
            //this.labtestTableAdapter.Fill(this.ramaniDataSet.labtest);
            
           

        }

        private void bSave2_Click(object sender, EventArgs e)
        {

        }

        private void bClear2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tb_mrn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int m = Morning.ValueMember();
            int noon = Noon.ValueMember();
            int n = Night.ValueMember();

            int days = Days.ToString();
             b1.calculateTotalDosage(m, noon, n,days,out total);

            Days.text=total;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtPastIllness_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //To retrieve Medicine
            f_PatientDetails current = this;
             bDoctor bd=new bDoctor();
            string date=bd.getToday();
            int count = Medicine.RowCount;
            int morn,noon,night,days,total;
            string medname;
           
            DataGridViewRow row; 
            for (int i = 1; i < count; i++)
            {
                
                row= Medicine.CurrentRow;
                medname = row.Cells[0].Value.ToString();
                morn = Convert.ToInt16(row.Cells[1].Value);
                noon = Convert.ToInt16(row.Cells[2].Value);
                night = Convert.ToInt16(row.Cells[3].Value);
                days = Convert.ToInt16(row.Cells[4].Value);
                total = bd.calculateTotalDosage(morn, noon, night, days);
                bd.saveMedicinePrescribed(m, date, medname, total, "no");

            }
            // To retrieve lab order
            if (checkedListBox3.CheckedItems.Count != 0)
            {
                for (int j = 0; j < checkedListBox3.CheckedItems.Count ; j++)
                {
                    string v = checkedListBox3.CheckedItems[j].ToString();
                    bd.savelabOrder(m, v, date);
                    //MessageBox.Show(v);
                }
            }
            //Retrieve provisional Diagnosis
            bd.saveProvisional(m, rtProvisionalDiagnosis.Text, date);
            int mrn = Convert.ToInt32(m);
            
            bd.setAppointmentStatus(mrn, date);
            current.Close();


        }

        private void bSave1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bSave_Click_1(object sender, EventArgs e)
        {
            bSave1_Click(sender, e);
        }

        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            
            bool gen, emer;
            f_PatientDetails current = this;


            bpatientInfo patient = new bpatientInfo();
            bRegistration reg = new bRegistration();
            validationOfForms val = new validationOfForms();

            //patient.male=rbMale.

            patient.firstName = tFirstName.Text;
            patient.middleName = tMiddleName.Text;
            patient.lastName = tLastName.Text;


            patient.fatherName = tFatherName.Text;
            patient.occupation = tOccupation.Text;

            patient.mrn = Convert.ToInt32(tb_mrn.Text);
            patient.office = tOffice.Text;
            patient.religion = cReligion.Text;
            patient.ethnicity = tEthnicity.Text;
            patient.email = tEmail.Text;


            patient.streetAddress2 = tStreetAddress2.Text;
            patient.city2 = tCity2.Text;
            patient.state2 = tState2.Text;
            patient.zipcode2 = tZipCode2.Text;

            patient.streetAddress3 = tStreetAddress3.Text;
            patient.city3 = tCity3.Text;
            patient.state3 = tState3.Text;
            patient.zipcode3 = tZipCode3.Text;


            patient.phoneHomeCode = tHomePhoneCode.Text;
            patient.phoneOfficeCode = tOfficePhoneCode.Text;
            patient.phoneMobileCode = tMobileCode.Text;
            patient.phoneHome = tHomePhone.Text;
            patient.phoneMobile = tMobilePhone.Text;
            patient.phoneOffice = tOfficePhone.Text;


            patient.eEmail = tEmail1.Text;
            patient.eFirstName = tFirstName1.Text;
            patient.eMiddleName = tMiddleName1.Text;
            patient.eLastName = tLastName1.Text;
            patient.eHomestreet = tStreetAddress.Text;
            patient.eHomeCity = tCity.Text;
            patient.eHomeState = tState.Text;
            patient.eHomeZip = tZipCode.Text;
            patient.eOfficeStreet = tStreetAddress1.Text;
            patient.eOfficeCity = tCity1.Text;
            patient.eOfficeState = tState1.Text;
            patient.eOfficeZip = tZipCode1.Text;
            patient.eHomePhoneCode = tHomePhone1.Text;
            patient.eOfficePhoneCode = tOfficePhoneCode1.Text;
            patient.eMobilePhoneCode = tMobileCode.Text;
            patient.ePhoneHome = tHomePhone.Text;
            patient.ePhoneOffice = tOfficePhone1.Text;
            patient.ePhoneMobile = tMobilePhone1.Text;


            val.validateRegistrationForm(patient, out gen, out emer);


            if (gen && emer)
            {
                if (reg.update(patient))
                {

                    MessageBox.Show("Successfully Updated!!");
                    //f_ReceptionHome rec = new f_ReceptionHome();
                    //rec.Show();
                    current.Dispose();
                }
                else
                    MessageBox.Show("Problem with the connection to the database... Could not update successfully");


            }
            else if (gen)
            {
                tabEmergency.Show();
                tabEmergency.BringToFront();
                manEcity.Show();
                manEfirstName.Show();
                manEhomePhone.Show();
                manElastName.Show();
                manEstate.Show();
                manEstreet.Show();
                manEzip.Show();
                tabEmergency.Show();
                MessageBox.Show("\tFields are invalid!\nEnter the compulsory fields marked with *");
            }

            else
            {
                tabGeneral.Show();
                tabGeneral.BringToFront();

                mandatoryFirstName.Show();
                mandatoryFatherName.Show();
                mandatoryGender.Show();
                mandatoryHomeAddress.Show();
                mandatoryHomePhone.Show();
                mandatoryDOB.Show();
                mandatoryLastName.Show();
                mandatoryZip.Show();
                MessageBox.Show("enter the general items");
            }


        }

        private void tEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ll_logout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_PatientDetails current = this;
            Form1 obj = new Form1();
            obj.Show();
            this.Dispose();

        }

        private void bSave1_Click_2(object sender, EventArgs e)
        {
            bool gen, emer;
            f_PatientDetails current = this;


            bpatientInfo patient = new bpatientInfo();
            bRegistration reg = new bRegistration();
            validationOfForms val = new validationOfForms();

            //patient.male=rbMale.
            if (rbMale.Checked)
                patient.gender = "Male";
            else if (rbFemale.Checked)
                patient.gender = "Female";

            patient.dob = cMonth.Text + '/' + cDay.Text + '/' + cYear.Text;


            patient.firstName = tFirstName.Text;
            patient.middleName = tMiddleName.Text;
            patient.lastName = tLastName.Text;


            patient.fatherName = tFatherName.Text;
            patient.occupation = tOccupation.Text;

            //patient.mrn = Convert.ToInt32(tb_mrn.Text);
            patient.office = tOffice.Text;
            patient.religion = cReligion.Text;
            patient.ethnicity = tEthnicity.Text;
            patient.email = tEmail.Text;


            patient.streetAddress2 = tStreetAddress2.Text;
            patient.city2 = tCity2.Text;
            patient.state2 = tState2.Text;
            patient.zipcode2 = tZipCode2.Text;

            patient.streetAddress3 = tStreetAddress3.Text;
            patient.city3 = tCity3.Text;
            patient.state3 = tState3.Text;
            patient.zipcode3 = tZipCode3.Text;


            patient.phoneHomeCode = tHomePhoneCode.Text;
            patient.phoneOfficeCode = tOfficePhoneCode.Text;
            patient.phoneMobileCode = tMobileCode.Text;
            patient.phoneHome = tHomePhone.Text;
            patient.phoneMobile = tMobilePhone.Text;
            patient.phoneOffice = tOfficePhone.Text;


            patient.eEmail = tEmail1.Text;
            patient.eFirstName = tFirstName1.Text;
            patient.eMiddleName = tMiddleName1.Text;
            patient.eLastName = tLastName1.Text;
            patient.eHomestreet = tStreetAddress.Text;
            patient.eHomeCity = tCity.Text;
            patient.eHomeState = tState.Text;
            patient.eHomeZip = tZipCode.Text;
            patient.eOfficeStreet = tStreetAddress1.Text;
            patient.eOfficeCity = tCity1.Text;
            patient.eOfficeState = tState1.Text;
            patient.eOfficeZip = tZipCode1.Text;
            patient.eHomePhoneCode = tHomePhone1.Text;
            patient.eOfficePhoneCode = tOfficePhoneCode1.Text;
            patient.eMobilePhoneCode = tMobileCode.Text;
            patient.ePhoneHome = tHomePhone.Text;
            patient.ePhoneOffice = tOfficePhone1.Text;
            patient.ePhoneMobile = tMobilePhone1.Text;


            val.validateRegistrationForm(patient, out gen, out emer);


            if (gen && emer)
            {
                reg.register(patient);

                MessageBox.Show("Successful Registration!!");

                //f_ReceptionHome rec = new f_ReceptionHome();
                //rec.Show();
                current.Dispose();

            }
            else if (gen)
            {
                tabEmergency.Show();
                tabEmergency.BringToFront();
                manEcity.Show();
                manEfirstName.Show();
                manEhomePhone.Show();
                manElastName.Show();
                manEstate.Show();
                manEstreet.Show();
                manEzip.Show();
                tabEmergency.Show();


                MessageBox.Show("\tFields are invalid!\nEnter the compulsory fields marked with *");
            }

            else
            {
                tabGeneral.Show();
                tabGeneral.BringToFront();

                mandatoryFirstName.Show();
                mandatoryFatherName.Show();
                mandatoryGender.Show();
                mandatoryHomeAddress.Show();
                mandatoryHomePhone.Show();
                mandatoryDOB.Show();
                mandatoryLastName.Show();
                mandatoryZip.Show();
                MessageBox.Show("enter the general items");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tb_mrn_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
