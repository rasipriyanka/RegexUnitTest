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
        public static string last = "^[A-Z][A-Z a-z]{3,}$";
        public string LastName;

        //-------Constructor----------//
        public Registration(string lastName) 
        {
            //-----Initializing---//
            this.LastName = lastName;
        }
        //-------Method Starts-------//
        public string ValidatingLastName()
        {

            if (Regex.IsMatch(LastName, last))
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
    

