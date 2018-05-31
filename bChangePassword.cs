using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace login1
{
    public class bChangePassword
    {
        public bChangePassword()
        {
        }

        public bool checkNewPassword(string role,string oldPassword,string newPassword,string confirmPassword)
        {
            bool status;
            dbChangePassword obj = new dbChangePassword();

            if (newPassword == confirmPassword)
            {

                if (obj.passwordChangeCheck(role, oldPassword, newPassword))
                {
                    status = true;
                }

                else
                {
                    status = false;
                }

                return status;

            }
            else
            {
                return false;
            }

        }

    }
}
