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
        public static string Pattern = @"^[A-Za-z0-9]{8,}$";
        public string Password;

        //-------Constructor----------//
        public Registration(string pwd) 
        {
            //-----Initializing---//
            this.Password = pwd;
        }
        //-------Method Starts-------//
        public string ValidatingPassword()
        {

            if (Regex.IsMatch(Password, Pattern))
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
    

