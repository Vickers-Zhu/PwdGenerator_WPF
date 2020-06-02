﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project
{
    public class ImgItem : BaseItem
    {
        public static int Count { get; set; }
        private string header;
        private bool isEditable = false;
        public ImgItem(ObservableCollection<BaseItem> Parent) : base(Parent)
        {
        }
        public string Header
        {
            get => header;

            set
            {
                header = value;
                OnPropertyChanged("Header");
            }
        }
        public bool IsEditable
        {
            get => isEditable;
            set
            {
                isEditable = value;
                OnPropertyChanged("IsEditable");
            }
        }
    }
}
