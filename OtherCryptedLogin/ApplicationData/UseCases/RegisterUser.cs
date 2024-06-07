using OtherCryptedLogin.Domain.Entities;
using OtherCryptedLogin.Domain.Services;
using OtherCryptedLogin.Infrastructure.Repositories;

namespace OtherCryptedLogin.ApplicationData.UseCases
{
    public class RegisterUser
    {
        private readonly IEncryptionService _encryptionService;
        private readonly IPasswordValidator _passwordValidator;
        private readonly IEmailValidator _emailValidator;
        private readonly UserRepository _userRepository;

        public RegisterUser(IEncryptionService encryptionService, IPasswordValidator passwordValidator, IEmailValidator emailValidator, UserRepository userRepository)
        {
            _encryptionService = encryptionService;
            _passwordValidator = passwordValidator;
            _emailValidator = emailValidator;
            _userRepository = userRepository;
        }

        public bool Execute(string email, string password)
        {
            if (!_emailValidator.Validate(email))
            {
                return false;
            }

            if (!_passwordValidator.Validate(password))
            {
                return false;
            }

            var user = new User
            {
                Email = _encryptionService.Encrypt(email.ToLower()),
                Password = _encryptionService.Encrypt(password)
            };

            try
            {
                _userRepository.Save(user);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
