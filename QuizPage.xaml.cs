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

namespace Quiz
{
    /// <summary>
    /// Interaction logic for QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Page
    {
        public int Score = 0;
        public QuizPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NoFristQ.IsChecked == true) { Score++; }
            if (YesSecontQ.IsChecked == true) { Score++; }
            if (NoThirdQ.IsChecked == true) { Score++; }
            if (YesForthQ.IsChecked == true) { Score++; }
            Result result = new Result(Score);
            this.NavigationService.Navigate(result);
        }
    }
}