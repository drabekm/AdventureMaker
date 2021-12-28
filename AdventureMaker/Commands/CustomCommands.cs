using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventureMaker.Commands
{
    public static class CustomCommands
    {
		public static readonly RoutedUICommand AddRoom = new RoutedUICommand
			(
				"AddRoom",
				"AddRoom",
				typeof(CustomCommands)
			);

		public static readonly RoutedUICommand RemoveRoom = new RoutedUICommand
			(
				"RemoveRoom",
				"RemoveRoom",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Delete)
				}
			);

		public static readonly RoutedUICommand AddItem = new RoutedUICommand
			(
				"AddItem",
				"AddItem",
				typeof(CustomCommands)
			);

		public static readonly RoutedUICommand RemoveItem = new RoutedUICommand
			(
				"RemoveItem",
				"RemoveItem",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Delete)
				}
			);

		public static readonly RoutedUICommand ClearComboBox = new RoutedUICommand
			(
				"ClearComboBox",
				"ClearComboBox",
				typeof(CustomCommands)
			);

		public static readonly RoutedUICommand LoadGame = new RoutedUICommand
			(
				"LoadGame",
				"LoadGame",
				typeof(CustomCommands),
				new InputGestureCollection()
                {
					new KeyGesture(Key.O, ModifierKeys.Control)
                }
			);

		public static readonly RoutedUICommand SaveGame = new RoutedUICommand
			(
				"SaveGame",
				"SaveGame",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.S, ModifierKeys.Control)
				}
			);
	}
}
