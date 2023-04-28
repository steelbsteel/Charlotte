using Charlotte.DateBase;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Charlotte
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:\\Users\\user\\source\\repos\\Charlotte\\Charlotte\\Images\\AuthBackground.jpg", UriKind.Absolute));
            this.Background = myBrush;
        }

        private void SignInBtnClick(object sender, RoutedEventArgs e)
        {
            User user = App.db.CheckUserSignedIn(loginTextBox.Text, passwordBox.Password);
            if (user != null)
            {
                MessageBox.Show("Входы был успешно осуществлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                var menu = new Menu(user);
                this.Close();
                menu.Show();
            }
            else
                MessageBox.Show("Вход не был выполнен", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void SignUpBtnClick(object sender, RoutedEventArgs e)
        {
            var window = new RegistrationWindow();
            this.Close();
            window.Show();
        }
    }
}
