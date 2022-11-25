using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram.Commands
{
    public abstract class FileManagerCommand
    {
        public abstract DataDirectores[] DataDirs { get; set; } 

        public abstract void Execute(string[] args);
    }
}
