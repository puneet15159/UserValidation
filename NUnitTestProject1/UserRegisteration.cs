using System;
using System.Text.RegularExpressions;

namespace NUnitTestProject1
{
    class UserRegisteration
    {
        Regex firstNameRegex = new Regex(@"[A-Z]{1}[a-z]{2,}");
        Regex lastNameRegex = new Regex(@"[A-Z]{1}[a-z]{2,}");
        Regex emailRegex = new Regex(@"^[a-bA-Z]{3,}[0-9]*([.\-\+]{1}([a-z]{3,})?[0-9]*)?@[a-zA-Z]{2,}[.][a-z]{2,}([.][a-z]{2,3})?$");
        Regex phoneNumberRegex = new Regex(@"[91]{1} [0-9]{10}");
        Regex passwordRegex = new Regex(@"[a-zA-Z0-9]{8}");
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

        internal bool validateEmail(string email)
        {
            if (emailRegex.IsMatch(email))
            {
                return true;
            }
            else
                return false;
        }

        internal bool validateMobileNumber(string phoneNumber)
        {
            if (phoneNumberRegex.IsMatch(phoneNumber))
            {
                return true;
            }
            else
                return false;
        }

        internal bool validatePassword(string password)
        {
            if (passwordRegex.IsMatch(password))
            {
                return true;
            }
            else
                return false;
        }
    }
}