using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_in_Array
{
   public class SmallestElementInArray
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
