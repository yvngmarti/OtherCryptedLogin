using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using OtherCryptedLogin.ApplicationData.UseCases;
using OtherCryptedLogin.Infrastructure.Repositories;
using OtherCryptedLogin.Infrastructure.ServicesImplementation;
using OtherCryptedLogin.Presentation;

namespace OtherCryptedLogin
{
    public partial class MainWindow : Window
    {
        private readonly ValidateUser _validateUser;

        public MainWindow()
        {
            InitializeComponent();
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtPassword.PasswordChanged += txtPassword_PasswordChanged;

            var encryptionService = new EncryptionService();
            var userRepository = new UserRepository();
            _validateUser = new ValidateUser(encryptionService, userRepository);
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
            TogglePlaceholder(txtEmail, textEmail);
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            TogglePlaceholder(txtPassword, textPassword);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            if (_validateUser.Execute(email, password))
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}
