using AdventureMaker.Models;
using AdventureMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AdventureMaker.Commands
{
    internal class AddRoomCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            RoomEditorViewModel viewmodel = parameter as RoomEditorViewModel;
            if (viewmodel != null)
            {
                int newID = 1;
                if (viewmodel.Rooms.Any())
                {
                    newID = viewmodel.Rooms.LastOrDefault().RoomID + 1;
                }
                var newRoom = new Room() { RoomDescription = "New description", RoomID = newID, RoomName = $"New room {newID}" };
                viewmodel.Rooms.Add(newRoom);
                viewmodel.CurrentRoom = newRoom;
            }
        }
    }
}
