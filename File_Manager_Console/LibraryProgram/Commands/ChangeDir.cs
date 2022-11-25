using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryProgram.Commands
{
    internal sealed class ChangeDir : FileManagerCommand
    {
        public override DataDirectores[] DataDirs { get; set; }

        public ChangeDir(DataDirectores[] dataDir)
        {
            DataDirs = dataDir;
        }

        public override void Execute(string[] args)
        {
            DataDirs[DataDirectores.Select_Window] = new DataDirectores(CheckCarrentName(args),
                    DataDirs[DataDirectores.Select_Window].Count_Lins);
        }
        private string CheckCarrentName(string[] args)
        {
            if (args.Length > 2) 
            {
                string result = args[1] + " " + args[2];
                if (Directory.Exists(result))
                    return result;
            }
            return args[1];
        }
    }
}
