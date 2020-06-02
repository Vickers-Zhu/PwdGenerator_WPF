using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project
{
    public class ImgItem : BaseItem
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
    }
}
