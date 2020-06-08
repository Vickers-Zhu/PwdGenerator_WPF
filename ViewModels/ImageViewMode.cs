using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.IO;

namespace WPF_Project
{
    class ImageViewMode : PwdViewModel
    {
        private ICommand saveImage;

        public ImageViewMode() 
        {
            SaveImage = new RelayCommand(SaveImg);
        }

           
        public ImgItem ImgItem 
        {
            get 
            {
                return SelectedImgItem;
            }
            set 
            {
                SelectedImgItem = value;
            }
        }

        public ICommand SaveImage 
        {
            get => saveImage;
            set 
            {
                saveImage = value;            
            }     
        }

        public BitmapImage Image { get => ImgItem.Image; }

        public void SaveImg(Object obj) 
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document";
            dlg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG File|*.png";
            if (dlg.ShowDialog() == true)
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(Image));
                using (var stream = dlg.OpenFile())
                {
                    encoder.Save(stream);
                }
            }
        }
    }
}
