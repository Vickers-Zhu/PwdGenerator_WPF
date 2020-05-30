using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public ObservableCollection<BaseItem> Items { get; set; }

        public Main()
        {
            InitializeComponent();
            Items = new ObservableCollection<BaseItem>();
            DirItem.Count = 0;
            PwdItem.Count = 0;
            ImgItem.Count = 0;
            this.DataContext = Items;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Login.xaml", UriKind.Relative));
        }

        private void Dir_Add(object sender, RoutedEventArgs e)
        {
            BaseItem item = new DirItem();
            item.Header = "New Directory " + (++DirItem.Count).ToString();
            Items.Add(item);
        }

        private void Pwd_Add(object sender, RoutedEventArgs e)
        {
            BaseItem item = new PwdItem();
            item.Header = "New Password " + (++PwdItem.Count).ToString();
            Items.Add(item);
        }

        private void Img_Add(object sender, RoutedEventArgs e)
        {
            BaseItem item = new ImgItem();
            item.Header = "New Image " + (++ImgItem.Count).ToString();
            Items.Add(item);
        }
    }
}
