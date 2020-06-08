using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project
{
    [Serializable]
    public abstract class BaseItem : INotifyPropertyChanged
    {
        [field: NonSerializedAttribute()]
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<BaseItem> parent;
        public ObservableCollection<BaseItem> Parent 
        { 
            get => parent;
            set 
            {
                parent = value;
                OnPropertyChanged("Parent");
            } 
        }
        public BaseItem() { }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
