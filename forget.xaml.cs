using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        facebookEntities db = new facebookEntities();

        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr_login2 ss = new userr_login2();
            ss = db.userr_login2.FirstOrDefault(x => x.username == nametext.Text);
           
                ss.username = nametext.Text;
                ss.passwordd = password.Text;
                db.userr_login2.AddOrUpdate(ss);
                db.SaveChanges();
                MessageBox.Show("Password Was updated successfully");
                login nn = new login();
                 this.NavigationService.Navigate(nn);
          
        }
    }
}
