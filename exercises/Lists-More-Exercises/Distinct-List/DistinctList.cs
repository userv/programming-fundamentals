using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_List
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                RemoveRepeatingElements(numbers[i], numbers);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void RemoveRepeatingElements(int number, List<int> numbers)
        {
            bool removeNextElement = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (removeNextElement && numbers[i] == number)
                {
                    numbers.RemoveAt(i);
                }
                else if (!removeNextElement && numbers[i] == number)
                {
                    removeNextElement = true;
                }
            }
        }
    }
}
