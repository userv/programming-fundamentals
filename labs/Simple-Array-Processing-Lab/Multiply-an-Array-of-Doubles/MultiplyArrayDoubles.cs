using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_an_Array_of_Doubles
{
    class MultiplyArrayDoubles
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ')
                                                 .Select(double.Parse)
                                                 .ToArray();
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
