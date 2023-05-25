using Charlotte.DateBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Window
    {
        string _idHero;
        User _user;
        bool _isMenuPrevious;
        public CharacterPage(User user, string idHero, bool isMenuPrevious)
        {
            InitializeComponent();
            _user = user;
            _idHero = idHero;
            SuperPowersTB.Text = App.db.GetCharacterSuperpowers(idHero);
            List<Commentary> comments = App.db.GetCurrentCharacterCommentaries(idHero);
            try
            {
                addictionalImagesLV.ItemsSource = App.db.GetCurrentPageAddictionalImages(_idHero);
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
            this.DataContext = App.db.GetCurrentCharacter(_idHero);
        }

        private void createCommentaryBtnClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(commentaryFormTB.Text))
            {
                App.db.CreateCommentary(_user.Login, commentaryFormTB.Text, _idHero);
                MessageBox.Show("Комментарий успешно оставлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                var window = new CharacterPage(_user, _idHero, _isMenuPrevious);
                this.Close();
                window.Show();
            }

            else
            {
                MessageBox.Show("Комментарий не может быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_isMenuPrevious)
            {
                var menuWindow = new Menu(_user);
                this.Close();
                menuWindow.Show();
            }
            else
            {
                var window = new Characters(_user);
                window.Show();
                this.Close();
            }
        }

        private void SuperPowersTBPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (SuperPowersTB.Text == "Отсутствуют")
            {
                MessageBox.Show("У персонажа нет суперспособностей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string name = SuperPowersTB.Text;
                SuperPower power = App.db.SearchSuperPower(name);
                var window = new SuperpowerPage(_user, power.IdSuperPower, false, true, _isMenuPrevious);
                this.Close();
                window.Show();
            }
        }
    }
}
