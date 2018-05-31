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
    
    public partial class changePasswordForm : Form
    {

        public string role;
        public string oldPassword;
        public string newPassword;
        public string confirmPassword;


        public changePasswordForm(string role)
        {
            this.role = role;
            InitializeComponent();
            
        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }

       
        private void bClear_Click(object sender, EventArgs e)
        {
            tOldPassword.Text = tNewPassword.Text = tNewPasswordConfirm.Text = null;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            bool oldp,newp,confirmp,status;
            oldPassword = tOldPassword.Text;
            newPassword = tNewPassword.Text;
            confirmPassword = tNewPasswordConfirm.Text;
            //bChangePassword change=new bChangePassword();
            changePasswordForm current = this;

            validationOfForms val = new validationOfForms();
            

           status= val.validateChangePasswordForm(role,oldPassword,newPassword,confirmPassword,out oldp,out newp, out confirmp);
            if (oldp)
                mandatoryOld.Show();
            else
                mandatoryOld.Hide();
           
            if (newp)
                mandatoryNew.Show();
            else
                mandatoryNew.Hide();
            
            if (confirmp)
                mandatoryConfirm.Show();
            else
                mandatoryConfirm.Hide();

            if (status)
                current.Dispose();


           /* if(!(oldp&&newp&&confirmp))
            {

                if (change.checkNewPassword(role, oldPassword, newPassword, confirmPassword))
                {
                    MessageBox.Show("Password Change Successful!!!");
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Unsuccessful!\nTry Again");

                }
            }

            else
            {
                MessageBox.Show("Try Again");
            }*/
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
