using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int digitsCount = 0;
            bool isValid = true;
            bool onlyLettersAndDigits = true;
            PasswordValidation(password, ref digitsCount, ref isValid, ref onlyLettersAndDigits);
        }

        private static void PasswordValidation(string password, ref int digitsCount, ref bool isValid, ref bool onlyLettersAndDigits)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digitsCount++;
                }
                if (password[i] < 'a' && password[i] > 'z' || password[i] < 'A' && password[i] > 'Z' || password[i] < '0' && password[i] > 9)
                {
                    onlyLettersAndDigits = false;
                    isValid = false;
                }
            }
            if (!onlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");

            }
            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
