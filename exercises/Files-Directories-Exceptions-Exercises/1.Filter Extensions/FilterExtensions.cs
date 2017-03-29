using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Filter_Extensions
{
    public class FilterExtensions
    {
        public static void Main(string[] args)
        {
            string filterExtension = Console.ReadLine();
            filterExtension = "." + filterExtension;
            try
            {
                string[] files = Directory.GetFiles("input");
                foreach (var file in files)
                {
                    FileInfo fileInfo=new FileInfo(file);
                    if (fileInfo.Extension==filterExtension)
                    {
                        Console.WriteLine(fileInfo.Name);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Path not found!");
                //Console.WriteLine(e);
               // throw;
            }
            

        }
    }
}
