using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace login1
{
    public class bpatientInfo
    {
        public string firstName, middleName, lastName, fatherName, gender, occupation, office;
        public string religion, ethnicity, streetAddress2,city2,state2,zipcode2,streetAddress3,city3,state3,zipcode3,HomePhoneCode;
        public string  phoneHome,phoneHomeCode,phoneMobile, phoneMobileCode,phoneOffice,phoneOfficeCode;
        public string email,dob;
        //knownAllergies,knownIllness,
        public string eFirstName,eMiddleName,eLastName;
        public string ePhoneHome,eHomePhoneCode,ePhoneMobile,eMobilePhoneCode,ePhoneOffice,eOfficePhoneCode,eHomestreet,eHomeCity,eOfficeCity,eHomeState,eOfficeState,eOfficeStreet,eHomeZip,eOfficeZip,eEmail;
      
       public int mrn;
       //public bool male, female;

        public   bpatientInfo()
        {
        firstName= middleName=dob= lastName= fatherName= gender= occupation= office=email=null;
        religion= ethnicity= streetAddress2=city2=state2=zipcode2=streetAddress3=city3=state3=zipcode3=HomePhoneCode=null;
        phoneHome=phoneMobile=phoneHomeCode= phoneMobileCode=phoneOffice=phoneOfficeCode=null;
         eFirstName=eMiddleName=eLastName=null;
         ePhoneHome=eHomePhoneCode=ePhoneMobile=eMobilePhoneCode=ePhoneOffice=eOfficePhoneCode=eHomestreet=eHomeCity=eOfficeCity=eHomeState=eOfficeStreet=eOfficeState=eHomeZip=eOfficeZip=eEmail=null;
         
            
            // religion= ethnicity= addressHome=addressOffice= phoneHome= phoneMobile= phoneOffice=null;
       // email=knownAllergies=knownIllness=emergencyFirstName=emergencyMiddleName=emergencyLastName=null;
        //emergencyPhoneHome=emergencyPhoneMobile=emergencyPhoneOffice=emergencyAddressHome=emergencyAddressOffice=emergencyEmail=null;
        //mrn=0;


        }

        //public fetchPatientInfo()
        //{


    }
}
