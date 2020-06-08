using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for Pwd.xaml
    /// </summary>
    public partial class Pwd : Page
    {
        public Pwd()
        {
            InitializeComponent();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(PwdList.ItemsSource);
            if(view != null)
                view.Filter = UserFilter;
            
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ((PwdEditorViewMode)this.DataContext).IsEditing = false;
        }
        private void PwdList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EditorFrame is null)
            {
                EditorFrame = new Frame();
            }
            EditorFrame.NavigationService.Navigate(new Uri("PwdViewer.xaml", UriKind.Relative));
            EditorFrame.Refresh();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PwdList is null) return;
            CollectionViewSource.GetDefaultView(PwdList.ItemsSource).Refresh();
        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(SearchBox.Text))
                return true;
            else
                return ((item as Items.Pwd).Name.IndexOf(SearchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void AddPwd_Click(object sender, RoutedEventArgs e)
        {
            EditorFrame.NavigationService.Navigate(new Uri("PwdEditor.xaml", UriKind.Relative)); 
        }

        private void EditorFrame_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            ((PwdEditorViewMode)this.DataContext).IsEditing = false;
            CollectionViewSource.GetDefaultView(PwdList.ItemsSource).Refresh();
        }
    }
}
