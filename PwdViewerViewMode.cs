using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
