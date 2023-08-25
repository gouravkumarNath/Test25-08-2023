using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ENTER USERNAME : ");
                string UserName = Console.ReadLine();
                Console.WriteLine("ENTER PASSWORD : ");
                string Password = Console.ReadLine();
                Validation(Password);
            }
            catch
            (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Validation(string Password)
        {
            if (string.IsNullOrWhiteSpace(Password))
            {
                throw new ArgumentException("Password cannot be empty");
            }
            if (Password.Length != 8)
            {
                throw new FormatException("Length must be 8 characters");
            }
            if (!Password.Any(char.IsUpper))
            {
                throw new FormatException("Must contain one upperCase");
            }
            if (!Password.Any(char.IsLower))
            {
                throw new FormatException("Must contain one Lower Case");
            }
            if (!Regex.IsMatch(Password, @"[@#$%^&*]"))
            {
                throw new FormatException("Must contain one special symbol");
            }
        }
    }
   
}



