using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WPF_Project;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.IO;

namespace WPF_Project
{
    class PwdViewModel : INotifyPropertyChanged
    {
        private ICommand dirAddCommand;
        private ICommand pwdAddCommand;
        private ICommand imgAddCommand;
        private ICommand dirAddInsideCommand;
        private ICommand pwdAddInsideCommand;
        private ICommand imgAddInsideCommand;
        private ICommand saveData;
        private static ObservableCollection<BaseItem> items;
        private static DirItem selectedDirItem;
        private static PwdItem selectedPwdItem;
        private static ImgItem selectedImgItem;
        public ObservableCollection<BaseItem> Items
        {
            get
            {
                if (items is null)
                    //items = new DirItem();
                    items = new ObservableCollection<BaseItem>();
                return items;
            }
            set
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }
        public DirItem SelectedDirItem
        {
            get => selectedDirItem;
            set
            {
                if (value is null && selectedDirItem != null) selectedDirItem.IsEditable = false;
                selectedDirItem = value;
                OnPropertyChanged("SelectedDirItem");
            }

        }
        public PwdItem SelectedPwdItem
        {
            get => selectedPwdItem;
            set
            {
                if (value is null && selectedPwdItem != null) selectedPwdItem.IsEditable = false;
                selectedPwdItem = value;
                OnPropertyChanged("SelectedPwdItem");
            }
        }

        public ImgItem SelectedImgItem
        {
            get => selectedImgItem;
            set
            {
                if (value is null && selectedImgItem != null) selectedImgItem.IsEditable = false;
                selectedImgItem = value;
                OnPropertyChanged("SelectedImgItem");
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
        public ICommand DirAddInsideCommand
        {
            get => dirAddInsideCommand;
            set
            {
                dirAddInsideCommand = value;
            }
        }
        public ICommand PwdAddInsideCommand
        {
            get => pwdAddInsideCommand;
            set
            {
                pwdAddInsideCommand = value;
            }
        }
        public ICommand ImgAddInsideCommand
        {
            get => imgAddInsideCommand;
            set
            {
                imgAddInsideCommand = value;
            }
        }
        public ICommand SaveData
        {
            get => saveData;
            set
            {
                saveData = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public PwdViewModel()
        {
            DirAddCommand = new RelayCommand(DirAdd);
            PwdAddCommand = new RelayCommand(PwdAdd);
            ImgAddCommand = new RelayCommand(ImgAdd);
            DirAddInsideCommand = new RelayCommand(DirAddInside);
            PwdAddInsideCommand = new RelayCommand(PwdAddInside);
            ImgAddInsideCommand = new RelayCommand(ImgAddInside);
            SaveData = new RelayCommand(Save);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void DirAdd(object obj)
        {
            Items.Add(new DirItem(Items)
            {
                Header = "New Directory " + (++DirItem.Count).ToString(),
            });
        }
        public void PwdAdd(object obj)
        {
            Items.Add(new PwdItem(Items)
            {
                Header = "New Password " + (++PwdItem.Count).ToString()
            });
        }
        public void ImgAdd(object obj)
        {
            Items.Add(new ImgItem(Items)
            {
                Header = "New Image " + (++ImgItem.Count).ToString()
            });
        }

        public void DirAddInside(object obj)
        {
            selectedDirItem.Items.Add(new DirItem(selectedDirItem.Items)
            {
                Header = "New Directory " + (++DirItem.Count).ToString()
            });
        }
        public void PwdAddInside(object obj)
        {
            selectedDirItem.Items.Add(new PwdItem(selectedDirItem.Items)
            {
                Header = "New Password " + (++PwdItem.Count).ToString()
            });
        }
        public void ImgAddInside(object obj)
        {
            selectedDirItem.Items.Add(new ImgItem(selectedDirItem.Items)
            {
                Header = "New Image " + (++ImgItem.Count).ToString()
            });
        }

        public void Save(object obj)
        {
            UnicodeEncoding uniEncoding = new UnicodeEncoding();
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream(10);
            //formatter.Serialize(memStream, "asdasd");
            //int count = 0;
            //byte[] byteArray = new byte[memStream.Length];
            //memStream.Seek(0, SeekOrigin.Begin);
            //while (count < memStream.Length) 
            //{
            //    byteArray[count++] = Convert.ToByte(memStream.ReadByte());
            //}

            //string result = (string)formatter.Deserialize(memStream);
            //Console.WriteLine(result);

            //byte[] bt = { 1, 2, 3, 5, 6 };
            //string st = "asdasd";
            //Console.WriteLine(Encoding.UTF8.GetString(DataEncryption.Decrypt(st, DataEncryption.Encrypt(st, bt))));
        }

        public void Delete(object obj) 
        {
            BaseItem item = obj as BaseItem;
            item.Parent.Remove(item);
        }

        private void DeleteItem(BaseItem item, ObservableCollection<BaseItem> its) 
        {
            //if (its == null) return;
            //if (its.Remove(item)) return;
            //if (item is DirItem)
            //    for (int i = 0; i < its.Count; i++) 
            //        DeleteItem(item, ((DirItem)item).Items);
        }
        public void Load() 
        {
        
        }
    }
}
