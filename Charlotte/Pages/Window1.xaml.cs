﻿using Charlotte.DateBase;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Character _character;
        User _user;
        List<byte[]> _images = new List<byte[]>();
        public Window1(User user)
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
                App.db.CreateNewCharacter(NameTB.Text, AgeTB.Text, DescriptionTB.Text, StatusTB.Text, File.ReadAllBytes(window.FileName), _images);

            }
            catch(Exception ex)
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

        private void AddictionalPhotoAddBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new OpenFileDialog();

            if (window.ShowDialog() != true)
            {
                MessageBox.Show("Изображение не выбрано");
                return;
            }
            _images.Add(File.ReadAllBytes(window.FileName));
        }
    }
}