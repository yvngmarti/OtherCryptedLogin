using OtherCryptedLogin.Domain.Services;
using System.Text.RegularExpressions;

namespace OtherCryptedLogin.Infrastructure.ServicesImplementation
{
    public class PasswordValidator : IPasswordValidator
    {
        public bool Validate(string password)
        {
            if (password.Length < 8)
                return false;

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;

            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;

            if (!Regex.IsMatch(password, @"[\.\-_!$@?%#&]"))
                return false;

            if (Regex.IsMatch(password, @"(\d)\1{2,}"))
                return false;

            if (Regex.IsMatch(password, @"(abc|ABC|xyz|XYZ|123|321|000|111|222|333|444|555|666|777|888|999)"))
                return false;

            return true;
        }
    }
}