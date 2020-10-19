using System;
using System.Text.RegularExpressions;

namespace UserRegistationProblem
{
    class Program
    {
        /// The user enters accordingly the different datas
        /// and they are validated by calling the respective methods
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration portal");
            Console.WriteLine("----------------------------------");
            ValidateUser validateUser = new ValidateUser();
            Console.WriteLine("Enter the firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine(validateUser.ValidateName(firstName, lastName));
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
           Console.WriteLine(validateUser.ValidateEmail(email));
            Console.WriteLine("Enter phone no");
            string phoneNo = Console.ReadLine();
            Console.WriteLine(validateUser.ValidateMobileNumber(phoneNo));
            Console.WriteLine("Enter password");
            string passWord = Console.ReadLine();
           Console.WriteLine(validateUser.ValidatePassword(passWord));
            Console.ReadKey();
        }
    }
}
