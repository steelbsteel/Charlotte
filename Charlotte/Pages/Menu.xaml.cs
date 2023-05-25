using Charlotte.DateBase;
using Charlotte.Pages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Charlotte
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        User _user;
        public Menu(User user)
        {
            InitializeComponent();
            _user = user;
            bestHeroesList.ItemsSource = App.db.GetBestCharacters();
            bestSuperPowerList.ItemsSource = App.db.GetBestSuperpowers();
            bestEpisodesList.ItemsSource = App.db.GetBestEpisodes();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _user;
        }

        private void OwnPagePreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var ownPage = new OwnPage(_user);
            this.Close();
            ownPage.Show();
        }

        private void CharactersWindowOpen(object sender, MouseButtonEventArgs e)
        {
            var window = new Characters(_user);
            window.Show();
            this.Close();
        }

        private void HelpBtnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это приложение - энциклопедия по аниме Шарлотта.\n" +
                            "На данной странице собраны популярные статьи из энциклопедии (наиболее комментируемые), нажав на определенный элемент из трех списков, вы можете перейти на статью c соответствующим названием. \n" +
                            "Нажав на надписи Герои, Суперспособности, Эпизоды - вы можете перейти на соответствующий раздел со статьями. ", "Помощь", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CreateCharacterBtnClick(object sender, RoutedEventArgs e)
        {
            var window = new Window1(_user);
            window.Show();
            this.Close();
        }

        private void bestHeroesListDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Character character = bestHeroesList.SelectedItem as Character;
                var window = new CharacterPage(_user, character.IdCharacter, true);
                this.Close();
                window.Show();
            }
            catch
            {
                return;
            }
        }

        private void BtnExitClick(object sender, RoutedEventArgs e)
        {
            var window = new AuthorizationWindow();
            this.Close();
            window.Show();
        }

        private void SuperPowersWindowOpen(object sender, MouseButtonEventArgs e)
        {
            var window = new SuperPowers(_user);
            window.Show();
            this.Close();
        }

        private void EpisodesWindowOpen(object sender, MouseButtonEventArgs e)
        {
            var window = new Episodes(_user);
            window.Show();
            this.Close();
        }

        private void bestSuperPowerListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                SuperPower superPower = bestSuperPowerList.SelectedItem as SuperPower;
                var window = new SuperpowerPage(_user, superPower.IdSuperPower, true, false, false);
                this.Close();
                window.Show();
            }
            catch
            {
                return;
            }
        }

        private void bestEpisodesListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Episode episode = bestEpisodesList.SelectedItem as Episode;
                var window = new EpisodePage(_user, episode.IdEpisode, true);
                this.Close();
                window.Show();
            }
            catch
            {
                return;
            }
        }

        private void CreateSuperPowerClick(object sender, RoutedEventArgs e)
        {
            var window = new CreateSuperpowerPage(_user);
            this.Close();
            window.Show();
        }

        private void CreateEpisodeClick(object sender, RoutedEventArgs e)
        {
            var window = new CreateEpisodePage(_user);
            this.Close();
            window.Show();
        }
    }
}
