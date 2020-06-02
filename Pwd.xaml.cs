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
            view.Filter = UserFilter;

        }
        private void PwdList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((PwdEditorViewMode)this.DataContext).SelectedPwd = (Items.Pwd)this.PwdList.SelectedItem;
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
    }
}
