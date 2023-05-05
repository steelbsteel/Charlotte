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
    /// Логика взаимодействия для EpisodePage.xaml
    /// </summary>
    public partial class EpisodePage : Window
    {
        string _idEpisode;
        User _user;
        bool _isMenuPrevious;
        public EpisodePage(User user, string idEpisode, bool isMenuPrevious)
        {
            InitializeComponent();
            _user = user;
            _idEpisode = idEpisode;
            List<Commentary> comments = App.db.GetCurrentEpisodeCommentaries(_idEpisode);
            try
            {
                addictionalImagesLV.ItemsSource = App.db.GetCurrentPageAddictionalImages(idEpisode);
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
            this.DataContext = App.db.GetCurrentEpisode(_idEpisode);
        }

        private void createCommentaryBtnClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(commentaryFormTB.Text))
            {
                App.db.CreateCommentary(_user.Login, commentaryFormTB.Text, _idEpisode);
                MessageBox.Show("Комментарий успешно оставлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                var window = new CharacterPage(_user, _idEpisode, _isMenuPrevious);
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
                var window = new Episodes(_user);
                window.Show();
                this.Close();
            }
        }
    }
}
