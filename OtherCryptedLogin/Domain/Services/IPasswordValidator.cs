namespace OtherCryptedLogin.Domain.Services
{
    public interface IPasswordValidator
    {
        bool Validate(string password);
    }
}