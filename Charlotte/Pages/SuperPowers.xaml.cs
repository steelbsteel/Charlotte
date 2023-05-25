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
    /// Логика взаимодействия для SuperPowers.xaml
    /// </summary>
    public partial class SuperPowers : Window
    {
        User _user;
        public SuperPowers(User user)
        {
            InitializeComponent();
            _user = user;
            SuperpowersList.ItemsSource = App.db.GetSuperPowers();
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

        private void GoToSuperpowerBtnClick(object sender, RoutedEventArgs e)
        {
            if (SuperpowersList.SelectedItem != null)
            {
                SuperPower character = SuperpowersList.SelectedItem as SuperPower;
                var window = new SuperpowerPage(_user, character.IdSuperPower, false, false, false);
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите суперспособность", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void SearchSuperpowers()
        {
            if (SuperpowersList == null)
            {
                return;
            }

            SuperpowersList.ItemsSource = App.db.GetSuperPowers().Where(x => x.Name.ToLower().Contains(SearchTB.Text.ToLower())).ToList();
        }

        private void SearchTBTextChanged(object sender, TextChangedEventArgs e)
        {
            SearchSuperpowers();
        }
    }
}
