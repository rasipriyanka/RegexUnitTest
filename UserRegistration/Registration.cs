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
        
        public static string first = "^[A-Z][A-Z a-z]{3,}$";
        public string FirstName;

        //-------Constructor----------//
        public Registration(string firstName) 
        {
            //-----Initializing---//
            this.FirstName = firstName;
        }
        //-------Method Starts-------//
        public string ValidatingFirstName()
        {

            if (Regex.IsMatch(FirstName, first))
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
    

