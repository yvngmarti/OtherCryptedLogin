using System.Windows;
using OtherCryptedLogin.ApplicationData.UseCases;
using OtherCryptedLogin.Infrastructure.Repositories;
using OtherCryptedLogin.Infrastructure.ServicesImplementation;

namespace OtherCryptedLogin.Presentation
{
    public partial class RegisterWindow : Window
    {
        private readonly RegisterUser _registerUser;

        public RegisterWindow()
        {
            InitializeComponent();
            var encryptionService = new EncryptionService();
            var passwordValidator = new PasswordValidator();
            var userRepository = new UserRepository();
            _registerUser = new RegisterUser(encryptionService, passwordValidator, userRepository);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string email = txtRegisterEmail.Text;
            string password = txtRegisterPassword.Password;

            if (_registerUser.Execute(email, password))
            {
                MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.");
                var mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("La contraseña no cumple con los requisitos de robustez.");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
