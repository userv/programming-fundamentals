using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Element_in_Array
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int largestNumber = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (largestNumber<numbers[i])
                {
                    largestNumber = numbers[i];
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}
