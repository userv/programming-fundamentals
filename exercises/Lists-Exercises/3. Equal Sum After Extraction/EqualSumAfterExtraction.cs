

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            List<int> numbersList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbersList2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbersList1.Count; i++)
            {
                while (numbersList2.IndexOf(numbersList1[i])!=-1)
                {
                    int index = numbersList2.IndexOf(numbersList1[i]);
                    numbersList2.RemoveAt(index);
                }
            }
            if (numbersList1.Sum()==numbersList2.Sum())
            {
                Console.WriteLine($"Yes. Sum: {numbersList1.Sum()}");
            }
            else
            {
                int sum = Math.Abs(numbersList1.Sum() - numbersList2.Sum());
                Console.WriteLine($"No. Diff: {sum}");
            }
            
        }

    }
}
