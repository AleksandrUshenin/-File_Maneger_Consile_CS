using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using LibraryProgram.DisplayKeys;

namespace LibraryProgram
{
    public class UserMenegement
    {
        private readonly DataDirectores[] DataDirs;
        private IUserInterface UserInterface;


        public UserMenegement(DataDirectores[] DataDirs, IUserInterface UserInterface)
        {
            this.DataDirs = DataDirs;
            this.UserInterface = UserInterface;
        }
        /// <summary>
        /// запуск
        /// </summary>
        /// <returns></returns>
        public string Start()
        {
            UserCommandInfo infoKey = UserInterface.ReadKey(true);
            if (infoKey.Key == null)
            {
                return " ";
            }
            switch (infoKey.Key)
            {
                case CommandKey.ChangeDirUpp:
                    return "cd " + Directory.GetParent
                        (
                           DataDirs[DataDirectores.Select_Window].DirHome
                        );
                //=======================================================
                case CommandKey.ChangeDir:
                    return "cd " + infoKey.LineCommand;
                //=======================================================
                case CommandKey.Chenge_Windows:
                    DataDirectores.Chenge_Windows();
                    break;
                //=======================================================
                case CommandKey.LineCommand:
                    return infoKey.LineCommand;
                //=======================================================
                case CommandKey.GetLength:
                    return "length " + infoKey.LineCommand;
                //=======================================================
                case CommandKey.Copy:
                    return "cp " + infoKey.LineCommand;
                //=======================================================
                case CommandKey.Exit:
                    FileManagerLogic.Stop();
                    break;
                //=======================================================
                case CommandKey.Get_Information:
                    break;
                //=======================================================
                default:    //исправить
                    return infoKey.LineCommand;
            }
            return " ";
        }
    }
}
