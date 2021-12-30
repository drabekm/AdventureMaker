using AdventureCore.Commands;
using AdventureCore.Models;
using AdventureMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AdventureMaker.Commands
{
    internal class RemoveRoomCommand : BaseCommand
    {
        private RoomEditorViewModel _viewmodel;

        public RemoveRoomCommand(RoomEditorViewModel viewmodel)
        {
            _viewmodel = viewmodel;
            _viewmodel.PropertyChanged += _viewmodel_PropertyChanged;
        }

        private void _viewmodel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(RoomEditorViewModel.CurrentRoom))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return _viewmodel.CurrentRoom != null;
        }

        public override void Execute(object parameter)
        {
            _viewmodel.Rooms.Remove(_viewmodel.CurrentRoom);
        }
    }
}
