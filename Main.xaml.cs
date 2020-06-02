using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {     
        public Main()
        {
            InitializeComponent();
            DirItem.Count = 0;
            PwdItem.Count = 0;
            ImgItem.Count = 0;           
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Login.xaml", UriKind.Relative));
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (TreeView.SelectedItem is PwdItem)
            {
                ((PwdViewModel)this.DataContext).SelectedPwdItem = (PwdItem)this.TreeView.SelectedItem;
                ((PwdViewModel)this.DataContext).SelectedImgItem = null;
                ((PwdViewModel)this.DataContext).SelectedDirItem = null;
                TreeView.ContextMenu = TreeView.Resources["PwdContextMenu"] as System.Windows.Controls.ContextMenu;
            }
            else if (TreeView.SelectedItem is DirItem)
            {
                ((PwdViewModel)this.DataContext).SelectedPwdItem = null;
                ((PwdViewModel)this.DataContext).SelectedImgItem = null;
                ((PwdViewModel)this.DataContext).SelectedDirItem = (DirItem)this.TreeView.SelectedItem;
                TreeView.ContextMenu = TreeView.Resources["DirContextMenu"] as System.Windows.Controls.ContextMenu;
            }
            else if (TreeView.SelectedItem is ImgItem) 
            {
                ((PwdViewModel)this.DataContext).SelectedPwdItem = null;
                ((PwdViewModel)this.DataContext).SelectedImgItem = (ImgItem)this.TreeView.SelectedItem;
                ((PwdViewModel)this.DataContext).SelectedDirItem = null;
                TreeView.ContextMenu = TreeView.Resources["ImgContextMenu"] as System.Windows.Controls.ContextMenu;
            }
            else 
            {
                ((PwdViewModel)this.DataContext).SelectedPwdItem = null;
                ((PwdViewModel)this.DataContext).SelectedImgItem = null;
                ((PwdViewModel)this.DataContext).SelectedDirItem = null;
            }
        }

        private void TreeView_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem treeViewItem = VisualUpwardSearch(e.OriginalSource as DependencyObject);

            if (treeViewItem != null)
            {
                treeViewItem.IsSelected = true;
                treeViewItem.Focus();
                e.Handled = true;
            }
            else 
            {
                TreeView.ContextMenu = TreeView.Resources["DefaultContextMenu"] as System.Windows.Controls.ContextMenu;
            }
        }
        static TreeViewItem VisualUpwardSearch(DependencyObject source)
        {
            while (source != null && !(source is TreeViewItem))
                source = VisualTreeHelper.GetParent(source);
            return source as TreeViewItem;
        }
    }
}
