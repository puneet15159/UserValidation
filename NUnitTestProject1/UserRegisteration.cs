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
        //Regex passwordRegex = new Regex(@"[a-zA-Z0-9]{8}");
        //Regex passwordRegex = new Regex(@"(?=.*[A-Z])");
        //Regex passwordRegex = new Regex(@"(?=.*\d)");
        Regex passwordRegex = new Regex(@"(?=.{1}\W)");
        public Boolean validateFirstName(string fName)
        {
            return firstNameRegex.IsMatch(fName);
            
        }

        internal bool validateLastName(string lName)
        {
            return lastNameRegex.IsMatch(lName);
        }

        internal bool validateEmail(string email)
        {
            return emailRegex.IsMatch(email);
        }

        internal bool validateMobileNumber(string phoneNumber)
        {
            return phoneNumberRegex.IsMatch(phoneNumber);
        }

        internal bool validatePassword(string password)
        {
            return passwordRegex.IsMatch(password);
        }
    }
}