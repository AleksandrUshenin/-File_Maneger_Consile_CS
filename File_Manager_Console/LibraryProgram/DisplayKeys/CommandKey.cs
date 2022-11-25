using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram.DisplayKeys
{
    // Сводка:
    //     Задает стандартные клавиши.
    public enum CommandKey
    {
        /// <summary>
        /// отсуствие команды 
        /// </summary>
        Null = 0,
        /// <summary>
        /// команда чтения сторка комманды
        /// </summary>
        LineCommand = 1,
        /// <summary>
        /// смена директории
        /// </summary>
        ChangeDir = 2,
        /// <summary>
        /// смена директории на родительскую
        /// </summary>
        ChangeDirUpp = 3,
        /// <summary>
        /// получение иформации
        /// </summary>
        GetLength = 4,
        /// <summary>
        /// копирование
        /// </summary>
        Copy = 5,
        /// <summary>
        /// смена рабочего окна
        /// </summary>
        Chenge_Windows = 9,
        /// <summary>
        /// выход из програмы
        /// </summary>
        Exit = 255,
        Get_Information = 10, 
        AutDatas = 11,
        /// <summary>
        /// сжатиь файл
        /// </summary>
        Compress = 12, 
        /// <summary>
        /// восто\ановить файл
        /// </summary>
        Inarhiving = 13
    }
}
