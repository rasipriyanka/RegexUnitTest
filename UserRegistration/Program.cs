using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex!");
            Registration register = new Registration("rasipendela");
            register.ValidatingPassword();
        }
    }
}

