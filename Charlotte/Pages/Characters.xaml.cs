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
    /// Логика взаимодействия для Characters.xaml
    /// </summary>
    public partial class Characters : Window
    {
        User _user;
        public Characters(User user)
        {
            InitializeComponent();
            _user = user;
            CharactersList.ItemsSource = App.db.GetCharacters();
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

        private void GoToCharacterBtnClick(object sender, RoutedEventArgs e)
        {
            if (CharactersList.SelectedItem != null)
            {
                Character character = CharactersList.SelectedItem as Character;
                var window = new CharacterPage(_user, character.IdCharacter, false);
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите персонажа","Внимание",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
