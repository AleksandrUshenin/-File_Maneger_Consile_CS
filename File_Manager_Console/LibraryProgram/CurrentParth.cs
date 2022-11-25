using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProgram
{
    public class CurrentParth
    {
        public static string GetPath(string path)
        {
            StringBuilder sb = new StringBuilder();
            if (path.Length > 90)
            {
                sb.Append(path.Substring(0, 25));
                sb.Append("*****");
                int l = path.Length - (path.Length - 90);
                sb.Append(path.Substring(l));
            }
            else
            {
                return path;
            }
            return sb.ToString();
        }
        public static int GetLength(string path) 
        {
            return GetPath(path).Length;
        }
        public static int GetLength(int pathLength)
        {
            return 30;
        }
    }
}
