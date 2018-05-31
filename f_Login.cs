using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.Common;


namespace login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(bool role, bool username, bool password)
        {

            InitializeComponent();
            if (username)
                enterUser.Show();// Calls error message if username is not entered
            if (password)
                enterPass.Show();//Calls error message if password is not entered
            if (role)
                enterRole.Show();//Calls error message if role is not entered
        }
       
        private void b_submit_Click(object sender, EventArgs e)
        {
            string r = c_role.Text;//String role is being read from the form
            string u = t_username.Text;//String username is being read from the form
            string p = t_password.Text;//String password is being read from the form
            bool flag;// Flag holds the success state of login form validation

            //this.Hide();
            Form1 current = this;
            
            validationOfForms validForm = new validationOfForms();//Class which validates the user enetered data
            flag = validForm.validateLoginForm(r, u, p,current);// Function of Class ValidationForms is used

            if (flag)
            {
                current.Hide();
               // MessageBox.Show("Login successful");
            }
            else

                MessageBox.Show("Login Failed. Try again");
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            t_password.Text = t_username.Text = null;
            c_role.Text = null;
        }
            

      /*  private void f_Login_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.t_username, "Select your role");

        }*/


       
    }
}
