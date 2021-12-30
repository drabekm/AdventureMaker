using AdventureCore.Commands;
using AdventureMaker.Helpers;
using AdventureMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureMaker.Commands
{
    internal class LoadGameCommand : BaseCommand
    {
        private readonly RoomEditorViewModel _viewmodel;

        public LoadGameCommand(RoomEditorViewModel viewmode)
        {
            _viewmodel = viewmode;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            var loadFileDialog = FileHelper.GetLoadGameFileDialog();
            if (loadFileDialog.ShowDialog() == true)
            {
                FileHelper.LoadRoomEditorViewModelData(_viewmodel, loadFileDialog.FileName);
            }
        }
    }
}
