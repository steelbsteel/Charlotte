using Charlotte.DateBase;
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

namespace Charlotte.Pages
{
    /// <summary>
    /// Логика взаимодействия для SuperpowerPage.xaml
    /// </summary>
    public partial class SuperpowerPage : Window
    {
        string _idSuperpower;
        User _user;
        bool _isMenuPrevious;
        bool _isCharacterPrevious;
        bool _isCharacterMenuPrevious;
        public SuperpowerPage(User user, string idSuperpower, bool isMenuPrevious, bool isCharacterPrevious, bool isCharacterMenuPrevious)
        {
            InitializeComponent();
            _user = user;
            _idSuperpower = idSuperpower;
            List<Commentary> comments = App.db.GetCurrentSuperPowerCommentaries(_idSuperpower);
            CommentariesList.ItemsSource = comments;
            _isMenuPrevious = isMenuPrevious;
            _isCharacterPrevious = isCharacterPrevious;
            _isCharacterMenuPrevious = isCharacterMenuPrevious;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = App.db.GetCurrentSuperPower(_idSuperpower);
        }

        private void createCommentaryBtnClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(commentaryFormTB.Text))
            {
                App.db.CreateCommentary(_user.Login, commentaryFormTB.Text, _idSuperpower);
                MessageBox.Show("Комментарий успешно оставлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                var window = new SuperpowerPage(_user, _idSuperpower, _isMenuPrevious, _isCharacterPrevious, _isCharacterMenuPrevious);
                this.Close();
                window.Show();
            }

            else
            {
                MessageBox.Show("Комментарий не может быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoBackBtnClick(object sender, RoutedEventArgs e)
        {
            if (_isCharacterPrevious)
            {
                var window = new CharacterPage(_user, App.db.SearchIdCharacterBySuperpower(_idSuperpower), _isCharacterMenuPrevious);
                this.Close();
                window.Show();
                return;
            }

            if (_isMenuPrevious)
            {
                var menuWindow = new Menu(_user);
                this.Close();
                menuWindow.Show();
                return;
            }

            else
            {
                var window = new SuperPowers(_user);
                window.Show();
                this.Close();
            }
        }
    }
}
