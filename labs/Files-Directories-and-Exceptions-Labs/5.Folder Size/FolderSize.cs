using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.Folder_Size
{
    public class FolderSize
    {
        public static void Main()
        {
            string[] dirs = Directory.GetDirectories("TestFolder");
            string[] files = Directory.GetFiles("TestFolder");
            double folderSize = 0;
            foreach (var file in files)
            {
                FileInfo fileInfo=new FileInfo(file);
                folderSize += fileInfo.Length;
            }
            Console.WriteLine(folderSize /1024/1024);
            File.WriteAllText("output.txt",$"{folderSize / 1024 / 1024}");
        }
    }
}
