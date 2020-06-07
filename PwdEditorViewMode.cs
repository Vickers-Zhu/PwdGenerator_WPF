using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WPF_Project
{
    class PwdEditorViewMode : PwdViewModel
    {
        private static Items.Pwd selectedPwd;
        private static bool isEditing;
        private static BitmapImage cacheImage;
        private ICommand onePwdAddCommand;
        private ICommand selectIcon;
        public Items.Pwd SelectedPwd 
        {
            get => selectedPwd;
            set 
            {
                selectedPwd = value;
                OnPropertyChanged("SelectedPwd");
            }
        }
        public bool IsEditing 
        {
            get => isEditing;
            set 
            {
                isEditing = value;
                OnPropertyChanged("IsEditing");
            }
        }
        public BitmapImage CacheImage
        {
            get => cacheImage;
            set
            {
                cacheImage = value;
                OnPropertyChanged("CacheImage");
            }
        }
        public ICommand OnePwdAddCommand 
        {
            get => onePwdAddCommand;
            set 
            {
                onePwdAddCommand = value;
            }
        }
        public ICommand SelectIcon 
        {
            get => selectIcon;
            set 
            {
                selectIcon = value;
            }
        }
        public ObservableCollection<Items.Pwd> Passwords
        {
            get
            {
                if (!(SelectedPwdItem is null))
                    return SelectedPwdItem.Passwords;
                return null;
            }
            set
            {
                if (!(SelectedPwdItem is null)) 
                {
                    SelectedPwdItem.Passwords = value;
                    OnPropertyChanged("Passwords");
                }
            }
        }
        public PwdEditorViewMode()
        {
            OnePwdAddCommand = new RelayCommand(AddPwd);
            SelectIcon = new RelayCommand(PickIcon);
        }
        public void AddPwd(object obj)
        {
            this.SelectedPwdItem.Passwords.Add(new Items.Pwd() 
            {
                Name = "Account Name",
                CreatedTime = DateTime.Now
            });
            IsEditing = true;
        }

        public void PickIcon(object obj) 
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                CacheImage = new BitmapImage(new Uri(op.FileName, UriKind.Absolute));
            }
        }
    }
}
