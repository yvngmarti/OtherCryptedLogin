using OtherCryptedLogin.Domain.Services;
using System.Text.RegularExpressions;

namespace OtherCryptedLogin.Infrastructure.ServicesImplementation
{
    public class EmailValidator : IEmailValidator
    {
        public bool Validate(string email)
        {
            var emailRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9.]*@[a-zA-Z]+\.(com|mx|com\.mx)$");
            return emailRegex.IsMatch(email);
        }
    }
}
