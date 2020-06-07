using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WPF_Project;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

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
        private ICommand loadData;
        private static ObservableCollection<BaseItem> items;
        private static DirItem selectedDirItem;
        private static PwdItem selectedPwdItem;
        private static ImgItem selectedImgItem;
        private static string passphrase;
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

        public string Passphrase 
        {
            get => passphrase;
            set 
            {
                passphrase = value;
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
        public ICommand LoadData 
        {
            get => loadData;
            set 
            {
                loadData = value;
            }
        }
        public ICommand ImgAddingCommand 
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
            Items.Add(new DirItem()
            {
                Header = "New Directory " + (++DirItem.Count).ToString(),
                Parent = Items
            });
        }
        public void PwdAdd(object obj)
        {
            Items.Add(new PwdItem()
            {
                Header = "New Password " + (++PwdItem.Count).ToString(),
                Parent = Items
            });
        }
        public void ImgAdd(object obj)
        {
            BitmapImage image = ImageAdding(null);
            if (image is null) return;
            Items.Add(new ImgItem()
            {
                Header = "New Image " + (++ImgItem.Count).ToString(),
                Parent = Items,
                Image = image
            });
        }

        public void DirAddInside(object obj)
        {
            selectedDirItem.Items.Add(new DirItem()
            {
                Header = "New Directory " + (++DirItem.Count).ToString(),
                Parent = selectedDirItem.Items
            });
        }
        public void PwdAddInside(object obj)
        {
            selectedDirItem.Items.Add(new PwdItem()
            {
                Header = "New Password " + (++PwdItem.Count).ToString(),
                Parent = selectedDirItem.Items
            });
        }
        public void ImgAddInside(object obj)
        {
            BitmapImage image = ImageAdding(null);
            if (image is null) return;
            selectedDirItem.Items.Add(new ImgItem()
            {
                Header = "New Image " + (++ImgItem.Count).ToString(),
                Parent = selectedDirItem.Items,
                Image = image
            });
        }

        public void Save(object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream(100000);
            int count = 0;
            byte[] byteArray;
            try
            {
                formatter.Serialize(memStream, Items);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                byteArray = new byte[memStream.Length];
                memStream.Seek(0, SeekOrigin.Begin);
                while (count < memStream.Length)
                {
                    byteArray[count++] = Convert.ToByte(memStream.ReadByte());
                }

                memStream.Close();
            }
            byte[] encryptedBytes = DataEncryption.Encrypt("qweasdzxc", byteArray);
            using (FileStream fs = new FileStream("Passwords.bin", FileMode.Create))
            {
                for (int i = 0; i < encryptedBytes.Length; i++) 
                {
                    fs.WriteByte(encryptedBytes[i]);
                }
            }
        }
        public static ObservableCollection<BaseItem> Load()
        {
            byte[] dataArray = System.IO.File.ReadAllBytes("Passwords.bin");
            byte[] decryptedBytes = DataEncryption.Decrypt("qweasdzxc", dataArray);
            MemoryStream memStream = new MemoryStream(100000);
            memStream.Write(decryptedBytes, 0, decryptedBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            ObservableCollection<BaseItem> result;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                result = formatter.Deserialize(memStream) as ObservableCollection<BaseItem>;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                memStream.Close();
            }
            return result;
        }
        public void Delete(object obj) 
        {
            BaseItem item = obj as BaseItem;
            item.Parent.Remove(item);
        }
        public BitmapImage ImageAdding(object obj)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                return new BitmapImage(new Uri(op.FileName, UriKind.Absolute));
            }
            return null;
        }
    }
}
