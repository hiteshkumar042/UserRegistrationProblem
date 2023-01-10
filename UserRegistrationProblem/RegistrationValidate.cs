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
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";

        public void ValidateFirstName(string name)
        {
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexfirst = new Regex(firstnameregex);
            if (regexfirst.IsMatch(name))
            {
                Console.WriteLine(name + " : Valid");
            }
            else
            {
                Console.WriteLine(name +" : Invalid");        
            }
        }
    }
}
