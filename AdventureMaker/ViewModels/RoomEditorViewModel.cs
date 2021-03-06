using AdventureCore.Models;
using AdventureCore.ViewModels.Models;
using AdventureMaker.Commands;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
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

        public ICommand AddRoomCommand { get; }
        public ICommand RemoveRoomCommand { get; }
        public ICommand SaveGameCommand { get; }
        public ICommand LoadGameCommand { get; }

        public RoomEditorViewModel()
        {
            _isRoomEditorOpen = true;
            _rooms = new ObservableCollection<Room>();
            _items = new ObservableCollection<Item>();

            AddRoomCommand = new AddRoomCommand(this);
            RemoveRoomCommand = new RemoveRoomCommand(this);
            LoadGameCommand = new LoadGameCommand(this);
            SaveGameCommand = new SaveGameCommand(this);

            Rooms.CollectionChanged += Rooms_CollectionChanged;
            Items.CollectionChanged += Items_CollectionChanged;
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Items));
        }

        private void Rooms_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Rooms));
        }


    }
}
