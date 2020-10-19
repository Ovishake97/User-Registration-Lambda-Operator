using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistationProblem
{
    /// Defining custom exceptions for empty and null values
   public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_EXCEPTION,
            NULL_EXCEPTION
        }
        public readonly ExceptionType type;

        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
