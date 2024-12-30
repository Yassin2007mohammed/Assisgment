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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Quiz
{
    /// <summary>
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        public Result(int score)
        {
            InitializeComponent();
            TextBlock1.Text = $"Your Score Is {score}/4";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome welcome = new Welcome();
            this.NavigationService.Navigate(welcome);
        }
    }
}