using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("input.txt");
            for (int i = 1; i < inputFile.Length; i+=2)
            {
                File.AppendAllText("output.txt",inputFile[i]+Environment.NewLine);
            }

        }
    }
}
