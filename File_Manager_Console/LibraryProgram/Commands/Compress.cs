using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace LibraryProgram.Commands
{
    class Compress : FileManagerCommand
    {
        public override DataDirectores[] DataDirs { get; set; }
        private IUserInterface UserInterface;
        private int indexlogic;

        public Compress(DataDirectores[] DataDirs, IUserInterface UserInterface, int indexlogic)
        {
            this.DataDirs = DataDirs;
            this.UserInterface = UserInterface;
            this.indexlogic = indexlogic;
        }

        public override void Execute(string[] args)
        {
            if (!File.Exists(args[1]))
                return;
            string path = DataDirs[0].DirHome;
            if (indexlogic == 1)
            {
                Compres(args[1], path);
            }
            else
            {
                Decompres(args[1], path);
            }
        }
        private async Task Compres(string namefile, string dirHome) 
        {
            using (FileStream stream = new FileStream(namefile, FileMode.OpenOrCreate))
            {
                string type = namefile.Split('.').Last();
                byte[] bType = new byte[type.Length + 1];
                bType[0] = (byte)'~';
                for (int i = 0; i < type.Length; i++) 
                {
                    bType[i + 1] = (byte)type[i];
                }
                stream.Position = stream.Length - 1;
                //stream.Write(bType, 0, bType.Length);
                //stream.
                //string nameType = namefile.Split('\\').Last().Split('.').Last();

                using (FileStream fs = File.Create(Path.Combine(dirHome, "result.gz")))
                {
                    using (GZipStream compres = new GZipStream(fs, CompressionMode.Compress))
                    {
                        await stream.CopyToAsync(compres);
                    }
                }
            }
        }
        private async Task Decompres(string namefile, string dirHome)
        {
            using (FileStream fs = new FileStream(namefile, FileMode.OpenOrCreate)) 
            {
                //string type = fs;
                using (FileStream fileS = File.Create("res.txt")) 
                {
                    using (GZipStream gz = new GZipStream(fs, CompressionMode.Decompress))
                    {
                        gz.CopyToAsync(fileS);
                    }
                }
            }
        }
    }
}

/*
 * string type = namefile.Split('.').Last();
                for (int i = 0; i < type.Length; i++) 
                {
                    listB.Add((int)type[i]);
                }
                listB.Add((int)'~');
                while (stream.Position < stream.Length)
                {
                    listB.Add(stream.ReadByte());
                }
 */
