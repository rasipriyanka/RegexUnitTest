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
        public static string emailaddress= @"^([A-Za-z0-9]*\.[A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3})+)$";
        public string Email;

        //-------Constructor----------//
        public Registration(string email) 
        {
            //-----Initializing---//
            this.Email = email;
        }
        //-------Method Starts-------//
        public string ValidatingEmail()
        {

            if (Regex.IsMatch(Email, emailaddress))
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
    

