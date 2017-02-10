using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers_at_Odd_Positions
{
   public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2 != 0) && ( i%2 != 0))
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
          
        }
    }
}
