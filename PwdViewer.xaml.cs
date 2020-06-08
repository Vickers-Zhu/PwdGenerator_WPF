using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for PwdViewer.xaml
    /// </summary>
    public partial class PwdViewer : Page
    {
        public PwdViewer()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            ((PwdViewerViewMode)this.DataContext).IsEditing = true;
            this.NavigationService.Navigate(new Uri("PwdEditor.xaml", UriKind.Relative));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ((PwdViewerViewMode)this.DataContext).SelectedPwdItem.Passwords
                .Remove(((PwdViewerViewMode)this.DataContext).SelectedPwd);
            ((PwdViewerViewMode)this.DataContext).SelectedPwd = null;
            while (this.NavigationService?.CanGoBack == true) 
            {
                this.NavigationService?.RemoveBackEntry();
            }
        }
        private void CopyEmail_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, 
                (Object)((PwdViewerViewMode)this.DataContext).Email);
        }

        private void CopyLogin_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetData(DataFormats.Text,
                (Object)((PwdViewerViewMode)this.DataContext).Login);
        }

        private void CopyPwd_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetData(DataFormats.Text,
                (Object)((PwdViewerViewMode)this.DataContext).Password);
        }
        private void Website_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            }
            catch (InvalidOperationException ev)
            {
                MessageBox.Show("This operation is not supported by a relative URI",
                    "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally 
            {
                e.Handled = true;
            }
        }
    }
}
