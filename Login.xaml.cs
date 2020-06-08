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

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.File.Exists("Passwords.bin")) 
            {
                if (txt_Pwd.Password != ((LoginViewMode)this.DataContext).Passphrase)              
                {
                    MessageBox.Show("Password is not correct",
                        "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            this.NavigationService.Navigate(new Uri("Main.xaml", UriKind.Relative));
        }
    }
}
