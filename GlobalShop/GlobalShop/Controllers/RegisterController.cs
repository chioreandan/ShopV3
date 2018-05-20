using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers
{
    public class RegisterController
    {
        public static void Register(string Nume, string Email, string Phone, string Adress, string Password, string Nickname)
        {
            User user = new User(Nume, Email, Phone, Adress, Password, Nickname);
            try
            {
                UserController.Create(user);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
        public static bool ValidatePassword(string password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;
            if (password == null) throw new ArgumentNullException();
            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;
            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }
            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;
        }
    }
}
