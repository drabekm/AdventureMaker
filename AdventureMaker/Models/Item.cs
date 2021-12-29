using System;
using System.Collections.Generic;
using System.Text;
using AdventureCore.ViewModels.Models;

namespace AdventureMaker.Models
{
    public class Item : BaseViewModel
    {
        private int _itemID;
        public int ItemID
        {
            get
            {
                return _itemID;
            }
            set
            {
                _itemID = value;
                OnPropertyChanged("ItemID");
            }
        }

        private string _itemName;
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
                OnPropertyChanged("ItemName");
            }
        }

        private string _itemDescription;
        public string ItemDescription
        {
            get
            {
                return _itemDescription;
            }
            set
            {
                _itemDescription = value;
                OnPropertyChanged("ItemDescription");
            }
        }

        public override string ToString()
        {
            return $"{ItemID} - {ItemName}";
        }
    }
}
