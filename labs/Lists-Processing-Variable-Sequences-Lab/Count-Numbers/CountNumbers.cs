using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > 0 && numbers[i] < 1000)
                {

                    if ((numbers[i] == numbers[i + 1]) && i == (numbers.Count - 2))
                    {
                        count += 2;
                        Console.WriteLine($"{numbers[i]} -> {count}");
                    }
                    else if (numbers[i] == numbers[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine($"{numbers[i]} -> {count}");
                        count = 0;
                    }
                }
            }
        }
    }
}
