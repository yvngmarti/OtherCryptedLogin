using OtherCryptedLogin.Domain.Entities;
using OtherCryptedLogin.Domain.Services;
using OtherCryptedLogin.Infrastructure.Repositories;

namespace OtherCryptedLogin.ApplicationData.UseCases
{
    public class RegisterUser
    {
        private readonly IEncryptionService _encryptionService;
        private readonly IPasswordValidator _passwordValidator;
        private readonly UserRepository _userRepository;

        public RegisterUser(IEncryptionService encryptionService, IPasswordValidator passwordValidator, UserRepository userRepository)
        {
            _encryptionService = encryptionService;
            _passwordValidator = passwordValidator;
            _userRepository = userRepository;
        }

        public bool Execute(string email, string password)
        {
            if (!_passwordValidator.Validate(password))
            {
                return false;
            }

            var user = new User
            {
                Email = _encryptionService.Encrypt(email),
                Password = _encryptionService.Encrypt(password)
            };

            _userRepository.Save(user);
            return true;
        }
    }
}