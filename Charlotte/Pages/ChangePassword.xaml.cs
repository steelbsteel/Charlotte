using Charlotte.DateBase;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using ZstdSharp.Unsafe;

namespace Charlotte.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public User _user;
        public ChangePassword(User currentUser)
        {
            InitializeComponent();
            _user = currentUser;
        }

        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentPassword.Password == newPassword.Password)
            {
                MessageBox.Show("Пароли должны отличаться", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (currentPassword.Password == _user.Password)
            {
                if (String.IsNullOrEmpty(newPassword.Password) &&
                    String.IsNullOrEmpty(newPasswordAccept.Password))
                {
                    MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (newPassword.Password == newPasswordAccept.Password)
                    {
                        MessageBoxResult mbox = MessageBox.Show("Вы уверены что хотите изменить пароль?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (mbox == MessageBoxResult.Yes)
                        {
                            App.db.ChangePassword(_user.Login, newPassword.Password);
                            MessageBox.Show("Пароль успешно изменен", "Успешно", MessageBoxButton.OK);
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Новый пароль отличается от пароля-подтверждения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
                MessageBox.Show("Проверьте правильность введенного текущего пароля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
