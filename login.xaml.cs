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

namespace facebook
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        facebookEntities db = new facebookEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr_login2 mm = new userr_login2();
            mm = db.userr_login2.FirstOrDefault(x => x.username == usertext.Text && x.passwordd == passtext.Text);
             if(mm != null)
             {
                homepage nn = new homepage();
                this.NavigationService.Navigate(nn);
             }
            else
            {
                MessageBox.Show("Error Login");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signup ii = new signup();
            this.NavigationService.Navigate(ii);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forget jj = new forget();
            this.NavigationService.Navigate(jj);
        }
    }
}
