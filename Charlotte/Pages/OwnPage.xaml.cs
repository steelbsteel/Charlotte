﻿using Charlotte.DateBase;
using Microsoft.Win32;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using System;
using System.Collections;
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
    /// Логика взаимодействия для OwnPage.xaml
    /// </summary>
    public partial class OwnPage : Window
    {
        User _user;
        public OwnPage(User currentUser)
        {
            InitializeComponent();
            _user = currentUser;
            CommentariesCountTB.Text = App.db.GetUserCommentaries(_user.Login).ToString();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _user;
        }

        private void GoBackBtnCLick(object sender, RoutedEventArgs e)
        {
            var main = new Menu(_user);
            this.Close();
            main.Show();
        }

        private void ChangePhotoBtnClick(object sender, RoutedEventArgs e)
        {
            var window = new OpenFileDialog();

            if (window.ShowDialog() != true)
            {
                MessageBox.Show("Изображение не выбрано");
                return;
            }
                
            App.db.UpdateUserPhoto(File.ReadAllBytes(window.FileName), _user.Login);
            MessageBox.Show("Фотография успешно обновлена");
            var ownPage = new OwnPage(App.db.GetCurrentUser(_user.Login));
            this.Close();
            ownPage.Show();
        }

        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            var changePasswordWindow = new ChangePassword(_user);
            changePasswordWindow.ShowDialog();
        }
    }
}
