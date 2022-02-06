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
        public static string Pattern = @"^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
        public string UpperCase;

        //-------Constructor----------//
        public Registration(string upper) 
        {
            //-----Initializing---//
            this.UpperCase = upper;
        }
        //-------Method Starts-------//
        public string ValidatingUpperCase()
        {

            if (Regex.IsMatch(UpperCase, Pattern))
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
    

