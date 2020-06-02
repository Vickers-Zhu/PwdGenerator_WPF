using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project
{
    public class PwdItem : BaseItem
    {
        public static int Count { get; set; }
        private string header;
        private bool isEditable = false;
        public PwdItem(ObservableCollection<BaseItem> Parent) : base(Parent)
        {
        }

        public string Header
        {
            get => header;

            set
            {
                header = value;
                OnPropertyChanged("Header");
            }
        }
        public bool IsEditable
        {
            get => isEditable;
            set
            {
                isEditable = value;
                OnPropertyChanged("IsEditable");
            }
        }

        private ObservableCollection<Items.Pwd> passwords;

        public ObservableCollection<Items.Pwd> Passwords
        {
            get 
            {
                if (passwords is null)
                    passwords = new ObservableCollection<Items.Pwd>();
                return passwords;
            }
            set 
            {
                passwords = value;
                OnPropertyChanged("Passwords");
            }
        }
        
    }
}
