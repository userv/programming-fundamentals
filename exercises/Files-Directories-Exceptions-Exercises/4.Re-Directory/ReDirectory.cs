using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.Re_Directory
{
    public class ReDirectory
    {
        public static void Main()
        {
            string inputPath = "input";
            string outputPath = "output";
            string[] files = Directory.GetFiles(inputPath);
            try
            {
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string outputDir = fileInfo.Extension + "s";
                    string path = outputPath + "\\" + outputDir.Trim('.');
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    File.Copy(file, path + "\\" + fileInfo.Name);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Path not found!");
                // throw;
            }
        }
    }
}
