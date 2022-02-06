using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex!");
            Registration register = new Registration("+91 8975675345");
            register.ValidatingMobileNum();
        }
    }
}

