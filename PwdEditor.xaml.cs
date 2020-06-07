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
    /// Interaction logic for PwdEditor.xaml
    /// </summary>
    public partial class PwdEditor : Page
    {
        public PwdEditor()
        {
            InitializeComponent();
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            ((PwdViewerViewMode)this.DataContext).IsEditing = false;
            ((PwdViewerViewMode)this.DataContext).CacheImage = null;
            this.NavigationService.Navigate(new Uri("PwdViewer.xaml", UriKind.Relative));
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Name = NameBox.Text;
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Email = EmailBox.Text;
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Login = LoginBox.Text;
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Password = PwdInput.Text;
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Website = WebBox.Text;
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Notes = NotesBox.Text;
            ((PwdViewerViewMode)this.DataContext).SelectedPwd.Icon =
                ((PwdViewerViewMode)this.DataContext).CacheImage;
            ((PwdViewerViewMode)this.DataContext).IsEditing = false;
            this.NavigationService.Navigate(new Uri("PwdViewer.xaml", UriKind.Relative));
        }
    }
}
