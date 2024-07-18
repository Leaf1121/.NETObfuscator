using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NetAssembly.Log
{
    class LogUtil
    {
        public static void SaveLog(string text)
        {
            string LogPath = Directory.GetCurrentDirectory() + @"\\Logs";
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }
            using(FileStream stream = new FileStream(LogPath + $@"\\{DateTime.Now.ToString("yyyy-MM-dd")} Log.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using(StreamWriter sw = new StreamWriter(stream))
                {
                    sw.WriteLine($"[{DateTime.Now.ToString("HH-mm-ss")}] " + text);
                }
            }
        }
    }
}
