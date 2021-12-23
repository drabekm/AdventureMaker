using AdventureMaker.ViewModels;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace AdventureMaker.Helpers
{
    public static class FileHelper
    {
        public static void LoadRoomEditorViewModelData(RoomEditorViewModel viewmodel, string filepath)
        {
            var json = File.ReadAllText(filepath);
            var tempViewmodel = JsonConvert.DeserializeObject<RoomEditorViewModel>(json);
            var roomsByRoomID = tempViewmodel.Rooms.ToDictionary(x => x.RoomID);

            viewmodel.Rooms.Clear();
            foreach (var room in tempViewmodel.Rooms)
            {
                room.NorthRoom = room.northRoomID > 0 ? roomsByRoomID[room.northRoomID] : null;
                room.SouthRoom = room.southRoomID > 0 ? roomsByRoomID[room.southRoomID] : null;
                room.WesthRoom = room.westRoomID > 0 ? roomsByRoomID[room.westRoomID] : null;
                room.EastRoom = room.eastRoomID > 0 ? roomsByRoomID[room.eastRoomID] : null;
                viewmodel.Rooms.Add(room);
            }
            viewmodel.CurrentRoom = viewmodel.Rooms.FirstOrDefault();



            viewmodel.Items.Clear();
            foreach (var item in tempViewmodel.Items)
            {
                viewmodel.Items.Add(item);
            }
            viewmodel.CurrentItem = viewmodel.Items.FirstOrDefault();
        }

        public static void SaveRoomEditorViewModelData(RoomEditorViewModel viewmodel, string filepath)
        {
            var viewModelJSON = JsonConvert.SerializeObject(viewmodel);
            File.WriteAllText(filepath, viewModelJSON);
        }

        public static SaveFileDialog GetSaveGameFileDialog()
        {
            return new SaveFileDialog()
            {
                Filter = "JSON file (*.json)|*.json|Game save file (*.nSave)|*.nSave",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };
        }

        public static OpenFileDialog GetLoadGameFileDialog()
        {
            return new OpenFileDialog()
            {
                Filter = "JSON file (*.json)|*.json|Game save file (*.nSave)|*.nSave",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };
        }
    }
}
