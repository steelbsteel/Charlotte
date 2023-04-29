using Charlotte.DateBase;
using Charlotte.Pages;
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
    }
}
