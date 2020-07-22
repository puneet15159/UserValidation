using System;
using System.Text.RegularExpressions;

namespace NUnitTestProject1
{
    class UserRegisteration
    {
        Regex firstNameRegex = new Regex(@"[A-Z]{1}[a-z]{2,}");
        Regex lastNameRegex = new Regex(@"[A-Z]{1}[a-z]{2,}");

        public Boolean validateFirstName(string fName)
        {
            if (firstNameRegex.IsMatch(fName))
            {
                return true;
            }
            else
                return false;
            
        }

        internal bool validateLastName(string lName)
        {
            if (lastNameRegex.IsMatch(lName))
            {
                return true;
            }
            else
                return false;
        }
    }
}