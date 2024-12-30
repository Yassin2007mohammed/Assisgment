using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        private  user _user;

        public profile()
        {
            InitializeComponent();
            this.DataContext = _user;  
        }
    }
}
