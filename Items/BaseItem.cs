using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project
{
    public class BaseItem : INotifyPropertyChanged
    {
        public string Header { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
