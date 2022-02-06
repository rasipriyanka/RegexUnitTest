using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//------Namespace-----//
namespace UserRegistration
{
    //------Class------//
    public class Registration
    {
        public static string MobileNum = @"^([\+][0-9]{2}\s*[0-9]{10})$";
        public string Mobile;

        //-------Constructor----------//
        public Registration(string mobile) 
        {
            //-----Initializing---//
            this.Mobile = mobile;
        }
        //-------Method Starts-------//
        public string ValidatingMobileNum()
        {

            if (Regex.IsMatch(Mobile, MobileNum))
            {
                return "valid";
            }
            else
            {
                return "In valid";
            }
        //------Method Ends---------//
            
        }
    }
}
    

