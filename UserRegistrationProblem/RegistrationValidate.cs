using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistrationProblem
{
    internal class RegistrationValidate
    {
        //First Name 
        public void ValidateFirstName(string fName)
        {
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexfirst = new Regex(firstnameregex);
            if (regexfirst.IsMatch(fName))
            {
                Console.WriteLine(fName + " : Valid");
            }
            else
            {
                Console.WriteLine(fName +" : Invalid");
                Console.WriteLine("--------------------");
            }
        }
        //Last Name 
        public void ValidateLastName(string lName)
        {
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexfirst = new Regex(firstnameregex);
            if (regexfirst.IsMatch(lName))
            {
                Console.WriteLine(lName + " : Valid");
            }
            else
            {
                Console.WriteLine(lName + " : Invalid");
                Console.WriteLine("--------------------");
            }
        }

    }
}
