using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.Merge_Files
{
   public  class MergeFiles
    {
        public static void Main()
        {
            string[] fileOneStrings = File.ReadAllLines("FileOne.txt");
            string[] fileTwoStrings = File.ReadAllLines("FileTwo.txt");
            for (int i = 0; i < fileOneStrings.Length; i++)
            {
                File.AppendAllText("output.txt", fileOneStrings[i]+Environment.NewLine);
                File.AppendAllText("output.txt", fileTwoStrings[i]+Environment.NewLine);
            }
            
        }

    }
}
