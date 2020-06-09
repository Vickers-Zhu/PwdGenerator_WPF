using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPF_Project
{
    class PwdViewerViewMode : PwdEditorViewMode
    {
        public BitmapImage Icon
        {
            get 
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Icon;
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Icon = value;
            }
        }
        public string Name
        {
            get 
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Name; 
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Name = value;
            }
        }
        public string Email
        {
            get
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Email;
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Email = value;
            }
        }
        public string Login
        {
            get 
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Login; 
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Login = value;
            }
        }
        public string Password
        {
            get 
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Password;
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Password = value;
            }
        }
        public string Website
        {
            get 
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Website; 
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Website = value;
            }
        }
        public string Notes
        {
            get
            {
                if (SelectedPwd is null) return null;
                return SelectedPwd.Notes;
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.Notes = value;
            }
        }

        public DateTime CreatedTime
        {
            get
            {
                if (SelectedPwd is null) return DateTime.MinValue;
                return SelectedPwd.CreatedTime;
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.CreatedTime = value;
            }
        }
        public DateTime EditedTime
        {
            get
            {
                if (SelectedPwd is null) return DateTime.MinValue;
                return SelectedPwd.EditedTime;
            }
            set
            {
                if (!(SelectedPwd is null))
                    SelectedPwd.EditedTime = value;
            }
        }
        public string Resolution 
        {
            get 
            {
                if (CacheImage is null) return null;
                return $"{CacheImage.Width}x{CacheImage.Height}";           
            }     
        }

        public string DPI 
        {
            get 
            {
                var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
                var dpiYProperty = typeof(SystemParameters).GetProperty("Dpi", BindingFlags.NonPublic | BindingFlags.Static);
                var dpiX = (int)dpiXProperty.GetValue(null, null);
                var dpiY = (int)dpiYProperty.GetValue(null, null); 
                return $"{dpiX}x{dpiY}";
            }
        }
        public string Format
        {
            get 
            {
                if (CacheImage is null) return null;
                return CacheImage.Format.ToString();
            }
        }
    }
}
