using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WPF_Project.Items
{
    [Serializable]
    public class Pwd : INotifyPropertyChanged
    {
        [field: NonSerializedAttribute()]
        private BitmapImage icon;
        private string name;
        private string email;
        private string login;
        private string password;
        private string website;
        private string notes;
        private DateTime createdTime;
        private DateTime editedTime;
        [field: NonSerializedAttribute()]
        public event PropertyChangedEventHandler PropertyChanged;
        public BitmapImage Icon 
        {
            get { return icon; }
            set 
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Website
        {
            get { return website; }
            set
            {
                website = value;
                OnPropertyChanged("Website");
            }
        }
        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged("Notes");
            }
        }

        public DateTime CreatedTime 
        {
            get => createdTime;
            set 
            {
                createdTime = value;
                OnPropertyChanged("CreatedTime");
            }
        }
        public DateTime EditedTime 
        {
            get => editedTime;
            set 
            {
                editedTime = value;
                OnPropertyChanged("EditedTime");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
