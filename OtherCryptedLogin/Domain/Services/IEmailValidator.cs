namespace OtherCryptedLogin.Domain.Services
{
    public interface IEmailValidator
    {
        bool Validate(string email);
    }
}
