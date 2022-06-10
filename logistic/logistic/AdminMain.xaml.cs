﻿using System;
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

namespace logistic
{
    /// <summary>
    /// Логика взаимодействия для AdminMain.xaml
    /// </summary>
    public partial class AdminMain : Window
    {
        public AdminMain()
        {
            InitializeComponent();
            MainFrame.Navigate(new ChoicePage());
            Manager.MainFrame = MainFrame;
        }

        private void MainFrame_ContentRender(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
                Btn_Back.Visibility = Visibility.Visible;
            else
                Btn_Back.Visibility = Visibility.Hidden;
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainW = new MainWindow();
            MainW.Show();
            this.Close();
        }
    }
}
