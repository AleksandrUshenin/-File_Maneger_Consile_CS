using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using LibraryProgram;

namespace TotalComanderOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SetWindowsSise();
            int siseWin = 20;
            LoadsettingsDirs();
            DataDirectores[] DataDirs = new DataDirectores[] 
            {
                new DataDirectores(Properties.Settings.Default.StartDir1, siseWin), 
                new DataDirectores(Properties.Settings.Default.StartDir2, siseWin) 
            };

            ConsoleUserInerface userInterface = new ConsoleUserInerface(DataDirs);

            FileManagerLogic MenegeLogik = new FileManagerLogic
                (
                    DataDirs,
                    userInterface
                );
            MenegeLogik.Start();
        }
        static void SetWindowsSise()
        {
            Console.WindowHeight = 34;
            Console.WindowWidth = 100;
            Console.BufferHeight = 34;
            Console.BufferWidth = 101;
            Console.Title = "File Maneger v3";
        }
        static void LoadsettingsDirs()
        {
            if (Properties.Settings.Default.StartDir1 == "")
            {
                Properties.Settings.Default.StartDir1 = Directory.GetCurrentDirectory();
                Properties.Settings.Default.StartDir2 = Properties.Settings.Default.StartDir1;
            }
            Properties.Settings.Default.Save();
        }
    }
}
