using System;
using System.Data.SqlClient;
using login1;


public class blogin
{
   
    
    public blogin()
    {
    }
    /*public bool validateFields(string role,string username,string password)
    {
        if (role == null)
            

    }*/

    
     
    
    public bool loginValidate(string role, string username, string password)
    {
        dbLogin obj=new dbLogin();
        
        if (obj.loginCheck(role, username, password))
        {
            switch (role)
            {
                case "Doctor":
                    f_DoctorHome fd = new f_DoctorHome();
                    fd.Show();
                    break;
                case "Receptionist": f_ReceptionHome rec = new f_ReceptionHome();//receptionist_home_screen rec = new receptionist_home_screen();
                    rec.Show(); //
                                              
                    break;

                case "Patient": 
                    break;
                case "Cashier": break;
                case "Pharmacist": f_PharmacyHomeScreen home = new f_PharmacyHomeScreen();
                    home.Show();
                    break;
                case "Lab Technician": f_Lab lab = new f_Lab();
                    lab.Show();

                    break;
                default: break;
            }

            return true;

        }
        else
        {
            return false;
        }



        /*public blogin(string role, string uname, string password)
        {


            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Trusted_Connection=false;Initial Catalog=ramani; Data Source=(local);persist security info=true;User id=cerner;password=manipal@321";
            cn.Open();

            string strSQL = "Select username,password From login1 where role='" + role + "'";

            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
            
                if ((uname == rd.GetString(rd.GetOrdinal("username"))) && (password == rd.GetString(rd.GetOrdinal("password"))))
                {

                    receptionist_home_screen receptionist = new receptionist_home_screen();
                    receptionist.Show();
                }

                else
                {
                   // MessageBox.Show(" login failed");
                    //role.Text = username.Text = password.Text = " ";

                }

            

            }

            rd.Close();
            cn.Close();
            Console.ReadLine();


    
        }*/
    }
}
