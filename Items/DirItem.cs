using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace WPF_Project
{
    [Serializable]
    public class DirItem : BaseItem
    {
        public static int Count { get; set; }
        private string header;
        private bool isEditable = false;
        private ObservableCollection<BaseItem> items;
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
        public ObservableCollection<BaseItem> Items 
        {
            get 
            {
                if (items is null) 
                {
                    items = new ObservableCollection<BaseItem>();
                }
                return items;
            }
            set 
            {
                items = value;
                OnPropertyChanged("DirItems");
            }
        }
    }
}
