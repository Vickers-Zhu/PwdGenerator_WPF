using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WPF_Project
{
    public class DirItem : BaseItem
    {
        public static int Count { get; set; }
        private string header;

        public string Header
        {
            get => header;

            set
            {
                header = value;
                OnPropertyChanged("Header");
            }
        }
        private ObservableCollection<BaseItem> items;
        public ObservableCollection<BaseItem> Items 
        {
            get 
            {
                if (items is null) items = new ObservableCollection<BaseItem>();
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
