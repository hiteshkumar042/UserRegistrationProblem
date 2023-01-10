using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    internal class RegistrationValidate
    {
        //For First Name validation 
        public void ValidateFirstName(string fName)
        {
            //First name pattern
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            //created an instance of Regex class
            Regex regexfirst = new Regex(firstnameregex);
            if (regexfirst.IsMatch(fName)) //True or False
            {
                Console.WriteLine(fName + " : Valid");
            }
            else
            {
                Console.WriteLine(fName + " : Invalid");
                Console.WriteLine("--------------------");
            }
        }
        //Last Name 
        public void ValidateLastName(string lName)
        {
            string lastnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            if (Regex.IsMatch(lName, lastnameregex))
            {
                Console.WriteLine(lName + " : Valid");
            }
            else
            {
                Console.WriteLine(lName + " : Invalid");
                Console.WriteLine("--------------------");
            }
        }
        //Email Id
        public void ValidateEmailId()
        {
            //Pattern for email Id
            string emailIdRegex = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            //Storing Email id in Array
            string[] emailIds = { "abc@yahoo.com","abc-100@yahoo.com", "abc.100@yahoo.com",
                                   "abc-100@abc.net", ".abc@abc.com","abc()*@gmail.com",
                                    "abc@gmail.com.aa.au", "abc@gmail.com.1a", "abc123@.com"};
            //printing all email ids
            foreach (string id in emailIds)
            {
                if (Regex.IsMatch(id, emailIdRegex)) //True or False
                {
                    Console.WriteLine(id + ": Valid");
                }
                else
                {
                    Console.WriteLine(id + " : Invalid");
                }
                
            }
            Console.WriteLine("--------------------------------");
        }
    }
}
