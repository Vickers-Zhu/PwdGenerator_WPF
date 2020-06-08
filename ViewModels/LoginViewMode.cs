using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Project
{
    class LoginViewMode : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static string passphrase = "qweasdzxc";
        private string inputedPwd;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string Passphrase
        {
            get => passphrase;
            set
            {
                passphrase = value;
                OnPropertyChanged("Passphrase");
            }
        }

        public string InputedPwd 
        {
            get => inputedPwd;
            set
            {
                inputedPwd = value;
                OnPropertyChanged("InputedPwd");
            }
        }
        public ObservableCollection<BaseItem> Load()
        {
            if (!System.IO.File.Exists("Passwords.bin")) return null;
            byte[] dataArray = System.IO.File.ReadAllBytes("Passwords.bin");
            byte[] decryptedBytes = DataEncryption.Decrypt(Passphrase, dataArray);
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
    }
}
