using AdventureCore.Commands;
using AdventureCore.Models;
using AdventureMaker.ViewModels;
using System;
using System.Linq;
using System.Windows.Input;

namespace AdventureMaker.Commands
{
    internal class AddRoomCommand : BaseCommand
    {
        private RoomEditorViewModel _viewmodel;

        public AddRoomCommand(RoomEditorViewModel viewmodel)
        {
            _viewmodel = viewmodel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            int newID = 1;
            if (_viewmodel.Rooms.Any())
            {
                newID = _viewmodel.Rooms.LastOrDefault().RoomID + 1;
            }
            var newRoom = new Room() { RoomDescription = "New description", RoomID = newID, RoomName = $"New room {newID}" };
            _viewmodel.Rooms.Add(newRoom);
            _viewmodel.CurrentRoom = newRoom;
        }
    }
}
