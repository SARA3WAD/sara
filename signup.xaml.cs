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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        facebookEntities db = new facebookEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr_login2 ss = new userr_login2();
            if(username.Text != "" && password.Text != "" && confirm.Text != "")
            {
                ss.username = username.Text;
                ss.passwordd = password.Text;
                ss.passwordd = confirm.Text;
                db.userr_login2.Add(ss);
                db.SaveChanges();
                MessageBox.Show("Sign up Successfully");
                login mm = new login();
                this.NavigationService.Navigate(mm);
            }
            
        }
    }
}
