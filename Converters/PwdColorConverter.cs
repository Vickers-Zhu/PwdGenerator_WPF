using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_Project
{
    class PwdColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PasswordStrength result = PasswordStrengthUtils.CalculatePasswordStrength((string)value);
            SolidColorBrush rs = null;
            switch (result)
            {
                case PasswordStrength.Invalid:
                    rs = new SolidColorBrush(Colors.Red);
                    break;
                case PasswordStrength.VeryWeak:
                    rs = new SolidColorBrush(Colors.Orange);
                    break;
                case PasswordStrength.Weak:
                    rs = new SolidColorBrush(Colors.Yellow);
                    break;
                case PasswordStrength.Average:
                    rs = new SolidColorBrush(Colors.LightBlue);
                    break;
                case PasswordStrength.Strong:
                    rs = new SolidColorBrush(Colors.LightGreen);
                    break;
                case PasswordStrength.VeryStrong:
                    rs = new SolidColorBrush(Colors.Green);
                    break;
            }
            return rs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
