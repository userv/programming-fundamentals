using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrences_of_Larger_Numbers
{
    class CountOccurrencesLargerNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int biggerNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>p)
                {
                    biggerNumbers++;
                }
            }
            Console.WriteLine(biggerNumbers);
        }
    }
}
