using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AdventureMaker.Models
{
    public class Room : BaseNotifiableModel
    {
        private int _roomID;
        [JsonProperty("roomID")]
        public int RoomID
        {
            get
            {
                return _roomID;
            }
            set
            {
                _roomID = value;
                OnPropertyChanged("RoomID");
            }
        }
       
        private string _roomName;
        [JsonProperty("roomName")]
        public string RoomName
        {
            get
            {
                return _roomName;
            }
            set
            {
                _roomName = value;
                OnPropertyChanged("RoomName");
            }
        }

        private string _roomDescription;
        [JsonProperty("roomDescription")]
        public string RoomDescription
        {
            get
            {
                return _roomDescription;
            }
            set
            {
                _roomDescription = value;
                OnPropertyChanged("RoomDescription");
            }
        }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        private Room _northRoom;
        [JsonProperty("northRoomID")]
        public int northRoomID;
        
        private Room _southRoom;
        [JsonProperty("southRoomID")]
        public int southRoomID;

        private Room _eastRoom;
        [JsonProperty("eastRoomID")]
        public int eastRoomID;

        private Room _westRoom;
        [JsonProperty("westRoomID")]
        public int westRoomID;

        [JsonIgnore]
        public Room NorthRoom
        {
            get { return _northRoom; }
            set
            {
                _northRoom = value;
                northRoomID = value != null ? value.RoomID : 0;
                OnPropertyChanged("NorthRoom");
            }
        }

        [JsonIgnore]
        public Room SouthRoom
        {
            get { return _southRoom; }
            set
            {
                _southRoom = value;
                southRoomID = value != null ? value.RoomID : 0;
                OnPropertyChanged("SouthRoom");
            }
        }

        [JsonIgnore]
        public Room EastRoom
        {
            get { return _eastRoom; }
            set
            {
                _eastRoom = value;
                eastRoomID = value != null ? value.RoomID : 0;
                OnPropertyChanged("EastRoom");
            }
        }

        [JsonIgnore]
        public Room WesthRoom
        {
            get { return _westRoom; }
            set
            {
                _westRoom = value;
                westRoomID = value != null ? value.RoomID : 0;
                OnPropertyChanged("WesthRoom");
            }
        }

        public override string ToString()
        {
            return $"{RoomID} - {RoomName}";
        }
    }
}
