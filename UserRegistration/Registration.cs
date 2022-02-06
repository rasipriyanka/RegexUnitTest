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
        public static string Pattern = @"^(?=.*[@$!%*#?&])[a-zA-Z0-9@$!%*#?&]{8,}$";
        public string SpecialCharacter;

        //-------Constructor----------//
        public Registration(string specialchar) 
        {
            //-----Initializing---//
            this.SpecialCharacter = specialchar;
        }
        //-------Method Starts-------//
        public string Validatingspecialchar()
        {

            if (Regex.IsMatch(SpecialCharacter, Pattern))
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
    

