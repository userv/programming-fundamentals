using System;
using System.IO;

namespace _2.Line_Numbers
{
    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt");
            for (int i = 0; i < inputLines.Length; i++)
            {
               // Console.WriteLine($"{i+1}. {inputLines[i]}");
                File.AppendAllText("output.txt",$"{i+1}. {inputLines[i]}"+ Environment.NewLine);
            }
        }
    }
}
