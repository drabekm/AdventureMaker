using AdventureCore.Commands;
using AdventureMaker.Helpers;
using AdventureMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureMaker.Commands
{
    internal class SaveGameCommand : BaseCommand
    {
        private readonly RoomEditorViewModel _viewmodel;

        public SaveGameCommand(RoomEditorViewModel viewmodel)
        {
            _viewmodel = viewmodel;
            _viewmodel.PropertyChanged += _viewmodel_PropertyChanged;
        }

        private void _viewmodel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(RoomEditorViewModel.Rooms) || e.PropertyName == nameof(RoomEditorViewModel.Items))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return _viewmodel.Rooms.Any() || _viewmodel.Items.Any();
        }

        public override void Execute(object parameter)
        {
            var saveFileDialog = FileHelper.GetSaveGameFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                FileHelper.SaveRoomEditorViewModelData(_viewmodel, saveFileDialog.FileName);
            }
        }
    }
}
