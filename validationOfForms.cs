using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace login1
    {
    public class validationOfForms
    {
        public validationOfForms()//constructor
        {
        }
       

         public bool validateAppointmentForm(f_ScheduleAppointment app,string mrntext, string daytext, string monthtext, string yeartext, string hourtext, string mintext, string amorpmtext)//appointment form validation
         {
             if (mrntext == "" || daytext == "DD" || monthtext == "MM"||yeartext=="YYYY" || hourtext == "Hr" || mintext == "Min")
             { 
                 return false;
             }
             else
             {
                 dbAppointment db = new dbAppointment();
                 bool flag= db.checkMrn(mrntext);
                if (flag == true)
                {
                    app.Hide();
                    bAppointment appoint = new bAppointment(mrntext, daytext, monthtext, yeartext, hourtext, mintext, amorpmtext);
                    if (appoint.scheduleAppointment())
                    {
                        MessageBox.Show("Appointment fixed");
                        f_ReceptionHome rec = new f_ReceptionHome();
                        rec.Show();

                    }

                    else
                    {
                        MessageBox.Show("Time slot already booked! Try again!");
                        f_ReceptionHome rec = new f_ReceptionHome();
                        rec.Show();
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("The MRN entered is not valid! Please enter a valid number");
                    return true;
                }
             }
         }
        //
        //A Function to validate user entered data in Login form 
        //
         public bool validateLoginForm(string role, string username, string password,Form1 home)
         {
             bool r = false, u = false, p = false;// Holds status of role,username,password
             if (role == "")// This condition becomes true  when Role is not entered 
                 r = true;
             if (username == "")// This condition becomes true when username is not entered
                 u = true;
             if (password == "")//This condition becomes true when password is not entered
                 p = true;

             if (r || u || p)//On validating all 3 data values 
             {
                 Form1 obj = new Form1(r, u, p);
                 obj.Show();
                 home.Hide();
                 return false;
             }

             else
             {
                 blogin lobj = new blogin();//Calls blogin class

                 if (!lobj.loginValidate(role, username, password)) //Validates role
                 {                   
                     return false;
                 }
                 else
                 {
                     return true;
                 }
             }
         }
        
       
       
           
         public void validateRegistrationForm(bpatientInfo patient,out bool gen,out bool emer)//registration form validation
       {
           gen = emer = true;

           if (patient.firstName==""||patient.lastName==""||patient.fatherName==""||patient.state2==""||patient.zipcode2==""||patient.phoneHome==""||patient.phoneHomeCode==""||patient.city2=="")
           {
               gen = false;
              
           }
           else if (patient.eFirstName == "" || patient.eLastName == "" || patient.eHomestreet == "" || patient.eHomeCity == "" || patient.eHomeState == "" || patient.eHomeZip == "" || patient.eHomePhoneCode == "" || patient.ePhoneHome == "")
           {
               emer = false;
               
           }

          /* else
           {
               gen = true;
               emer = true;
           }*/
        }



        //
        //
        //

         public bool validateChangePasswordForm(string role,string oldPassword, string newPassword, string confirm, out bool oldp, out bool newp, out bool confirmp)
         {
             oldp = newp = confirmp = false;
             if (oldPassword == "")
                 oldp = true;
             if (newPassword == "")
                 newp = true;
             if (confirm == "")
                 confirmp = true;
             
             bChangePassword change = new bChangePassword();
             validationOfForms val = new validationOfForms();
             if (!(oldp||newp|| confirmp))
             {

                 if (change.checkNewPassword(role, oldPassword, newPassword, confirm))
                 {
                     MessageBox.Show("Password Change Successful!!!");
                     //this.Dispose();
                     return true;
                 }

                 else
                 {
                     MessageBox.Show("Unsuccessful!\nTry Again");
                     return false;

                 }
             }
             else
                 return false;

         }

    
    }
}
