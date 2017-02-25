using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Insertion
{
    public class IntegerInsertion
    {
        public static void Main()
        {
            List<int> intsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string inputLine = string.Empty;
            while (inputLine!="end")
            {
                inputLine = Console.ReadLine();
                if (inputLine!="end")
                {
                    int firsDigit = int.Parse(inputLine[0].ToString());
                    intsList.Insert(firsDigit,int.Parse(inputLine));
                }
            }
            Console.WriteLine(string.Join(" ",intsList));
        }
    }
}
