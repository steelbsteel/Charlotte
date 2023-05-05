using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Charlotte
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void SignUpBtnClick(object sender, RoutedEventArgs e)
        {
            bool isExists = App.db.CheckUserExists(loginTextBox.Text);

            if (isExists)
                MessageBox.Show("Такой пользователь уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            else
            {
                if ((passwordBox.Password.Contains("") &&
                    String.IsNullOrWhiteSpace(loginTextBox.Text) &&
                    String.IsNullOrWhiteSpace(emailTB.Text)))
                {
                    MessageBox.Show("Проверьте введенные данные на наличие пустых полей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!emailTB.Text.Contains("@"))
                {
                    MessageBox.Show("Введите E-mail корректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (passwordBox.Password == passwordBoxChecker.Password)
                {
                    App.db.CreateNewUser(loginTextBox.Text, passwordBox.Password, emailTB.Text);
                    MessageBox.Show("Регистрация успешно пройдена", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    var window = new AuthorizationWindow();
                    this.Close();
                    window.Show();
                }
                else
                    MessageBox.Show("Проверьте соответствие паролей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoBackBtnClick(object sender, RoutedEventArgs e)
        {
            var window = new AuthorizationWindow();
            this.Close();
            window.Show();
        }
    }
}
