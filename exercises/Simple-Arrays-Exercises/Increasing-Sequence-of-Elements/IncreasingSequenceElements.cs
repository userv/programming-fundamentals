using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Sequence_of_Elements
{
    class IncreasingSequenceElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasingSequence = true;
            for (int i = 1 ; i < array.Length; i++)
            {
                if (array[i]<array[i-1])
                {
                    isIncreasingSequence = false;
                    break;
                }
            }
            if (isIncreasingSequence)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
