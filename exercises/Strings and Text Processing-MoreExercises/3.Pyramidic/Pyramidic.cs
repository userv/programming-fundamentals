using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputLines = new string[n];
            List<string> pyramids = new List<string>();
            for (int i = 0; i < n; i++)
            {
                inputLines[i] = Console.ReadLine();
            }
            for (int i = 0; i < inputLines.Length; i++)
            {

                for (int j = 0; j < inputLines[i].Length; j++)
                {
                    string pyramid = String.Empty;
                    int line = 1;
                    char currentChar = inputLines[i][j];
                    for (int k = i; k < inputLines.Length; k++)
                    {
                        string nextLine = new string(currentChar, line);

                        if (inputLines[k].Contains(nextLine))
                        {
                            pyramid += nextLine + "\r\n";
                        }
                        else
                        {
                            break;
                        }
                        line += 2;
                    }
                    pyramids.Add(pyramid.Trim());
                }
            }
            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
