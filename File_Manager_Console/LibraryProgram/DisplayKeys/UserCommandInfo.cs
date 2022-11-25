using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram.DisplayKeys
{
    public sealed class UserCommandInfo
    {
        public CommandKey Key { get; private set; }
        public char KeyChar { get; private set; }
        public CommadnModifiers Modifiers { get; private set; }
        public string LineCommand { get; private set; }


        public UserCommandInfo(CommandKey Key)
        {
            this.Key = Key;
        }
        public UserCommandInfo(CommandKey Key, string LineCommand)
            : this(Key)
        {
            this.LineCommand = LineCommand;
        }

        public static bool operator !=(UserCommandInfo a, UserCommandInfo b)
        {
            return a.Key != b.Key;
        }
        public static bool operator ==(UserCommandInfo a, UserCommandInfo b)
        {
            return a.Key == b.Key;
        }
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
    }
}
