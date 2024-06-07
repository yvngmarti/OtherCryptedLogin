using System.Windows;
using System.Windows.Controls;
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
            var emailValidator = new EmailValidator();
            var userRepository = new UserRepository();
            _registerUser = new RegisterUser(encryptionService, passwordValidator, emailValidator, userRepository);
        }

        private void TogglePlaceholder(TextBox textBox, TextBlock textBlock)
        {
            textBlock.Visibility = string.IsNullOrEmpty(textBox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TogglePlaceholder(PasswordBox passwordBox, TextBlock textBlock)
        {
            textBlock.Visibility = string.IsNullOrEmpty(passwordBox.Password) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TogglePlaceholder(txtRegisterEmail, textEmail);
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            TogglePlaceholder(txtRegisterPassword, textPassword);
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
                MessageBox.Show("El registro ha fallado. Verifique su email y contraseña.");
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
