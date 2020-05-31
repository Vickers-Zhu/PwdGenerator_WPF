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

        private void frame_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateFrameDataContext(sender, null);
        }
        private void frame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            UpdateFrameDataContext(sender, null);
        }
        private void UpdateFrameDataContext(object sender, NavigationEventArgs e)
        {
            var content = _NavigationFrame.Content as FrameworkElement;
            if (content == null)
                return;
            content.DataContext = _NavigationFrame.DataContext;
        }
    }
}
