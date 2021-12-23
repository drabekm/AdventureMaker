﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdventureMaker.Models
{
    public abstract class BaseNotifiableModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}