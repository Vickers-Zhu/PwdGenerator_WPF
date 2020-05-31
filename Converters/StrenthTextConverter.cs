using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_Project
{
    class StrenthTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PasswordStrength result = PasswordStrengthUtils.CalculatePasswordStrength((string)value);
            string rs = null;
            switch (result)
            {
                case PasswordStrength.Invalid:
                    rs = "Invalid";
                    break;
                case PasswordStrength.VeryWeak:
                    rs = "VeryWeak";
                    break;
                case PasswordStrength.Weak:
                    rs = "Weak";
                    break;
                case PasswordStrength.Average:
                    rs = "Average";
                    break;
                case PasswordStrength.Strong:
                    rs = "Strong";
                    break;
                case PasswordStrength.VeryStrong:
                    rs = "VeryStrong";
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
