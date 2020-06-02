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
    public abstract class BaseItem : INotifyPropertyChanged, ISerializable
    {
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

        public BaseItem(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("PropertyChanged", PropertyChanged, typeof(PropertyChangedEventHandler));
            info.AddValue("parent", parent, typeof(ObservableCollection<BaseItem>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            PropertyChanged = (PropertyChangedEventHandler)info
                .GetValue("PropertyChanged", typeof(PropertyChangedEventHandler));
            parent = (ObservableCollection<BaseItem>)info
                .GetValue("parent", typeof(ObservableCollection<BaseItem>));
        }
    }
}
