using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ITMO.CsharpWPF.Lab05.Exercise02
{
    public class CustomCommands
    {
        static CustomCommands()
        {
            // новая коллекция
            InputGestureCollection myInputGestures = new InputGestureCollection();

            // добавляет соответствующую клавишу ввода, связанную с новой командой
            // (Ctrl + L)
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));

            // инициирует переменную, возвращающую настраиваемую команду
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGestures);
        }

        public static RoutedUICommand Launch { get; }
    }
}
