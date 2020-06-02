using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_Project
{
    class ViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) 
            {
                return null;
            }
            if (value is DirItem) 
            {
                return new Uri("Dir.xaml", UriKind.Relative);
            }
            if (value is ImgItem) 
            {
                return new Uri("Img.xaml", UriKind.Relative);
            }
            if (value is PwdItem) 
            {
                return new Uri("Pwd.xaml", UriKind.Relative);
            }
            throw new Exception("Failed to change page");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
