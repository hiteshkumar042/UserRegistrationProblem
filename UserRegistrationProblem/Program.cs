﻿namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message  
            Console.WriteLine("========================================\nWelcome To the User Registration Problem\n========================================");
            RegistrationValidate registrationValidate = new RegistrationValidate();
            //First Name 
            registrationValidate.ValidateFirstName("Hitesh");
            registrationValidate.ValidateFirstName("hitesh");
            //Last Name
            registrationValidate.ValidateLastName("Kumar");
            registrationValidate.ValidateLastName("kumar");
            //Email Id
            registrationValidate.ValidateEmailId();
            //Mobile Number
            registrationValidate.ValidateMobileNum();
            //PassWord
            Console.WriteLine("Rule 1 : Minimum 8 Characters\n");
            registrationValidate.ValidatePassword();


        }
    }
}