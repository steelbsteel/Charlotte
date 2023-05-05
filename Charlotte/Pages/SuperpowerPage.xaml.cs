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
        public SuperpowerPage(User user, string idSuperpower, bool isMenuPrevious)
        {
            InitializeComponent();
            _user = user;
            _idSuperpower = idSuperpower;
            List<Commentary> comments = App.db.GetCurrentSuperPowerCommentaries(_idSuperpower);
            try
            {
                addictionalImagesLV.ItemsSource = App.db.GetCurrentPageAddictionalImages(idSuperpower);
            }
            catch
            {
                return;
            }
            CommentariesList.ItemsSource = comments;
            _isMenuPrevious = isMenuPrevious;
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
                var window = new SuperpowerPage(_user, _idSuperpower, _isMenuPrevious);
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
            if (_isMenuPrevious)
            {
                var menuWindow = new Menu(_user);
                this.Close();
                menuWindow.Show();
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
