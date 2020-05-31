using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Project
{
    class PwdViewModel : INotifyPropertyChanged
    {
        private ICommand dirAddCommand;
        private ICommand pwdAddCommand;
        private ICommand imgAddCommand;
        private static ObservableCollection<BaseItem> items;
        public ObservableCollection<BaseItem> Items 
        {
            get 
            {
                if (items is null)
                    items = new ObservableCollection<BaseItem>();
                return items;
            }
            set 
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }

        public ICommand DirAddCommand 
        {
            get => dirAddCommand;
            set 
            {
                dirAddCommand = value;
            }
        }
        public ICommand PwdAddCommand 
        {
            get => pwdAddCommand;
            set 
            {
                pwdAddCommand = value;
            }
        }
        public ICommand ImgAddCommand 
        {
            get => imgAddCommand;
            set 
            {
                imgAddCommand = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public PwdViewModel() 
        {
            DirAddCommand = new RelayCommand(DirAdd);
            PwdAddCommand = new RelayCommand(PwdAdd);
            ImgAddCommand = new RelayCommand(ImgAdd);
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void DirAdd(object obj) 
        {
            BaseItem item = new DirItem();
            item.Header = "New Directory " + (++DirItem.Count).ToString();
            Items.Add(item);
        }        
        public void PwdAdd(object obj) 
        {
            BaseItem item = new PwdItem();
            item.Header = "New Password " + (++PwdItem.Count).ToString();
            Items.Add(item);
        }        
        public void ImgAdd(object obj) 
        {
            BaseItem item = new ImgItem();
            item.Header = "New Image " + (++ImgItem.Count).ToString();
            Items.Add(item);
        }
    }
}
