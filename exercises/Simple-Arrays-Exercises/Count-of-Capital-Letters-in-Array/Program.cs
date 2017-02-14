using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArray = Console.ReadLine().Split(' ').ToArray();
            int capitalLetters = 0;
            for (int i = 0; i < stringsArray.Length; i++)
            {
                string currentString = stringsArray[i];
                for (int j = 0; j < stringsArray[i].Length; j++)
                {
                    if ((((int) currentString[j]) >= 65) && ((int) currentString[j]) <= 90)
                    {
                        capitalLetters++;
                    }

                }
            }
            Console.WriteLine(capitalLetters);
        }
    }
}
