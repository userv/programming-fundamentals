using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            var evenOddProduct = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine(evenOddProduct);
        }

        static int GetMultipleOfEvensAndOdds(int num)
        {
            var product = GetSumOfOddDigits(num)*GetSumOfEvenDigits(num);
            return product;
        }

        private static int GetSumOfOddDigits(int num)
        {
            var sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var currentDigit = num%10;
                if (currentDigit%2 != 0)
                    sum += currentDigit;

                num /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int num)
        {
            var sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var currentDigit = num%10;
                if (currentDigit%2 == 0)
                    sum += currentDigit;

                num /= 10;
            }

            return sum;
        }


    }
}
