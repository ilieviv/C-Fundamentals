using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string result = PasswordIsValid(password);
            if (result == string.Empty)
            {
                result = "Password is valid";
            }
            Console.WriteLine(result);
        }

        static string PasswordIsValid(string password)
        {
            string output = string.Empty;

            if (password.Length < 6 || password.Length > 10)
            {
                output += "Password must be between 6 and 10 characters" + Environment.NewLine;
            }

            for (int i = 0; i < password.Length; i++)
            {
                //if ((password[i] < 48 || password[i] > 57) || (password[i] < 65 || password[i] > 90) || (password[i] < 97 || password[i] > 122))
                //{
                //    output += "Password must consist only of letters and digits" + Environment.NewLine;
                //    break;
                //}

                if (!(password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' && password[i] <= 'Z' || password[i] >= '0' && password[i] <= '9'))
                {
                    output += "Password must consist only of letters and digits" + Environment.NewLine;
                    break;
                }

            }

            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                output += "Password must have at least 2 digits" + Environment.NewLine;
            }
            return output;
        }
    }

}

