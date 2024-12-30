using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        public Signup()
        {
            InitializeComponent();
            user user1 = new user();
           
            this.DataContext = user1; 
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login Log=new login();
            NavigationService.Navigate(Log);

        }

      
            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
              
                user user1 = new user()
                {
                    firstname = firsttext.Text,
                    lastname = lasttext.Text,
                    email = ena.Text,
                    password = passtext.Text,
                    Phonenumber = int.TryParse(phonetext.Text, out int number) ? number : 0
                };

                profile profilePage = new profile();
               profilePage.DataContext = user1;
                NavigationService.Navigate(profilePage);
            }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            login login = new login();
            NavigationService.Navigate(login);
        }
    }
    class user
    {
        public user()
        {

        }
        public string firstname { get; set; }

        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int Phonenumber { get; set; }




    }
}
