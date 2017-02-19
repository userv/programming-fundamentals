using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            foreach (var num  in numbers)
            {
                if (num>=0)
                {
                    result.Add(num);
                }
            }
            if (result.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
