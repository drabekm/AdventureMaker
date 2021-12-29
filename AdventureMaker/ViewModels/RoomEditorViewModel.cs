using AdventureCore.ViewModels.Models;
using AdventureMaker.Commands;
using AdventureMaker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace AdventureMaker.ViewModels
{
    public class RoomEditorViewModel : BaseViewModel
    {        
        private ObservableCollection<Room> _rooms { get; set; }
        [JsonProperty("rooms")]
        public ObservableCollection<Room> Rooms
        {
            get { return _rooms; }
            set 
            {
                _rooms = value;
            }
        }

        private ObservableCollection<Item> _items { get; set; }
        [JsonProperty("items")]
        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }


        private Room _currentRoom { get; set; }
        [JsonIgnore]
        public Room CurrentRoom
        {
            get { return _currentRoom; }
            set 
            {
                _currentRoom = value;
                this.OnPropertyChanged("CurrentRoom");
            }
        }

        private Item _currentItem { get; set; }
        [JsonIgnore]
        public Item CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                this.OnPropertyChanged("CurrentItem");
            }
        }

        private bool _isRoomEditorOpen { get; set; }
        [JsonIgnore]
        public bool IsRoomEditorOpen
        {
            get { return _isRoomEditorOpen; }
            set
            {
                this._isRoomEditorOpen = value;
                
                this.OnPropertyChanged("IsRoomEditorOpen");
            }
        }

        private bool _isItemsEditorOpen { get; set; }
        [JsonIgnore]
        public bool IsItemsEditorOpen
        {
            get { return _isItemsEditorOpen;}
            set
            {
                this._isItemsEditorOpen = value;
                this.OnPropertyChanged("IsItemsEditorOpen");
            }
        }

        private bool _isNPCsEditorOpen { get; set; }
        [JsonIgnore]
        public bool IsNPCsEditorOpen
        {
            get { return _isNPCsEditorOpen;}
            set 
            {
                this._isNPCsEditorOpen = value;
                this.OnPropertyChanged("IsNPCsEditorOpen");
            }
        }

        public ICommand AddRoomCommand { get; set; }

        public RoomEditorViewModel()
        {
            _isRoomEditorOpen = true;
            _rooms = new ObservableCollection<Room>();
            _items = new ObservableCollection<Item>();

            AddRoomCommand = new AddRoomCommand();
        }
    }
}
