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
        //Mobile Number
        public void ValidateMobileNum()
        {
            //Pattern for email Id
            string mobileNumRegex = "^91[ ]*[6-9]{1}[0-9]{9}$";
            //Storing Email id in Array
            string[] mobileNums = {"918875208042","91 8875208042","232232244","34543fre34","00435435678" };
            //printing all email ids
            foreach (string mNums in mobileNums)
            {
                if (Regex.IsMatch(mNums, mobileNumRegex)) //True or False
                {
                    Console.WriteLine(mNums + ": Valid");
                }
                else
                {
                    Console.WriteLine(mNums + " : Invalid");
                }

            }
            Console.WriteLine("--------------------------------");
        }
        //Password
        public void ValidatePassword()
        {
            //UC5 & UC6
            string passWordRegex = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            //Storing Email id in Array
            string[] passWords = { "12345678", "87654321", "abcdefgh", "123456789","Hitesh@1234", "00435435678","Password","PASS2023","Hhhhhhhhh","Hjkdhkd15" };
            //printing all email ids
            foreach (string password in passWords)
            {
                if (Regex.IsMatch(password, passWordRegex)) //True or False
                {
                    Console.WriteLine(password + ": Valid");
                }
                else
                {
                    Console.WriteLine(password + " : Invalid");
                }

            }
            Console.WriteLine("--------------------------------");
        }
    }
}
