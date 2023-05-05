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
    /// Логика взаимодействия для Episodes.xaml
    /// </summary>
    public partial class Episodes : Window
    {
        User _user;
        public Episodes(User user)
        {
            InitializeComponent();
            _user=user;
            EpisodesList.ItemsSource = App.db.GetEpisodes();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _user;
        }
        private void OwnPagePreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var ownPage = new OwnPage(_user);
            this.Close();
            ownPage.Show();
        }
        private void GoBackBtnCLick(object sender, RoutedEventArgs e)
        {
            var main = new Menu(_user);
            this.Close();
            main.Show();
        }

        private void GoToEpisodeBtnClick(object sender, RoutedEventArgs e)
        {
            if (EpisodesList.SelectedItem != null)
            {
                Episode character = EpisodesList.SelectedItem as Episode;
                var window = new CharacterPage(_user, character.IdEpisode, false);
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите эпизод", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
