using OtherCryptedLogin.Domain.Services;
using OtherCryptedLogin.Infrastructure.Repositories;

namespace OtherCryptedLogin.ApplicationData.UseCases
{
    public class ValidateUser
    {
        private readonly IEncryptionService _encryptionService;
        private readonly UserRepository _userRepository;

        public ValidateUser(IEncryptionService encryptionService, UserRepository userRepository)
        {
            _encryptionService = encryptionService;
            _userRepository = userRepository;
        }

        public bool Execute(string email, string password)
        {
            var users = _userRepository.GetAll();
            var encryptedEmail = _encryptionService.Encrypt(email);
            var encryptedPassword = _encryptionService.Encrypt(password);

            foreach (var user in users)
            {
                if (user.Email == encryptedEmail && user.Password == encryptedPassword)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
