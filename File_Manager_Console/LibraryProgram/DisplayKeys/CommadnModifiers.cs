using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram.DisplayKeys
{
    // Сводка:
    //     Представляет клавиши SHIFT, ALT и CTRL на клавиатуре.
    [Flags]
    public enum CommadnModifiers
    {
        // Сводка:
        //     Клавиша ALT слева и справа.
        Alt = 1,
        //
        // Сводка:
        //     Клавиша SHIFT слева и справа.
        Shift = 2,
        //
        // Сводка:
        //     Клавиша CTRL слева и справа.
        Control = 4,
    }
}
