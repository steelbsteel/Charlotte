using Charlotte.DateBase;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для CreateSuperpowerPage.xaml
    /// </summary>
    public partial class CreateSuperpowerPage : Window
    {
        Character _character;
        User _user;
        public CreateSuperpowerPage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void CreatePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new OpenFileDialog();

            if (window.ShowDialog() != true)
            {
                MessageBox.Show("Изображение не выбрано");
                return;
            }

            MessageBox.Show("Фотография успешно обновлена");
            try
            {
                Character character = CharactersListView.SelectedItem as Character;
                App.db.CreateNewSuperPower(NameTB.Text, DescriptionTB.Text, File.ReadAllBytes(window.FileName), character.IdCharacter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new Menu(_user);
            window.Show();
            this.Close();
        }
    }
}
