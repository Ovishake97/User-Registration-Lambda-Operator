using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

namespace UserRegistationProblem
{
   public class ValidateUser
    {
        public string firstName;
        public string lastName;
        public string email;
        public double phoneNo;
        public string passWord;

        /// With the help of lambda operator
        /// defining a method that returns
        /// if the pattern mathces with the corresponding data
        public Func<string,string, bool> Matches = (a,b) =>
        { Regex regex = new Regex(b);
           return regex.IsMatch(a);
            };

        /// ValidateName method validates the firstname
        /// and the lastname entered by the user
        /// with the available pattern
        /// and throws custom exceptions in case of null and empty values.
        public string ValidateName(string firstName, string lastName)
        {
           string pattern="^[A-Z]{1}[a-z]{2,}";
           
            bool flag1 = Matches(firstName,pattern);
            bool flag2 = Matches(lastName,pattern);

            try
            {
                if (firstName.Equals(string.Empty) || lastName.Equals(string.Empty))
                {

                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "Names cannot be empty");
                }
                if (flag1 == true && flag2 == true)
                {
                    return "Valid firstname and lastname";
                }
                else if (flag1 == true && flag2 == false)
                {
                    return "Firstname is valid but lastname is invalid";
                }
                else if (flag1 == false && flag2 == true) {
                    return "Firstname is invalid but lastname is valid";
                }
                else
                {
                    return "Invalid firstname and lastname ";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null reference");
            }
        }

        /// ValidateEmail method validates the email id given by the user
        /// with the available pattern
        /// and throws custom exceptions in case of null and empty values.
        public string ValidateEmail(string email)
        {
            string pattern ="^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            bool flag = Matches(email, pattern);

            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "Email cannot be empty");
                }
                if (flag==true)
                {
                    return "Valid emailid";
                }

                else
                {
                    return "Invalid emailid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null reference");
            }

        }

        /// ValidateMobileNumber method validates the mobile number given by the user
        /// with the required pattern
        /// and throws custom exceptions in case of null and empty values
        public string ValidateMobileNumber(string phoneNo)
        {
            string pattern="^[0-9]{2}[ ][0-9]{10}";
            bool flag = Matches(phoneNo, pattern);

            try
            {
                if (phoneNo.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "Mobile number cannot be empty");
                }
                if (flag==true)
                {
                    return "Valid mobile number";
                }

                else
                {
                    return "Invalid mobile number";
                }

            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null reference");
            }
        }

        /// ValidatePassword checks for the validity of the password
        /// with the help of the available pattern
        /// and throws exception in case of null and empty values.
        public string ValidatePassword(string passWord)
        {
            string pattern= "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            bool flag = Matches(passWord, pattern);

            try
            {
                if (passWord.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_EXCEPTION, "Password cannot be empty");
                }
                if (flag == true)
                {
                    return "Valid password";
                }

                else
                {
                    return "Invalid password";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_EXCEPTION, "Null reference");
            }

        }
    }
}
