using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_Project
{
    class StrenthValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PasswordStrength result = PasswordStrengthUtils.CalculatePasswordStrength((string)value);
            int rs = 0;
            switch (result) 
            {
                case PasswordStrength.Invalid:
                    rs = 0;
                    break;
                case PasswordStrength.VeryWeak:
                    rs = 1;
                    break;
                case PasswordStrength.Weak:
                    rs = 2;
                    break;
                case PasswordStrength.Average:
                    rs = 3;
                    break;
                case PasswordStrength.Strong:
                    rs = 4;
                    break;
                case PasswordStrength.VeryStrong:
                    rs = 5;
                    break;
            }
            return (int)rs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
