using System;
using System.Collections.Generic;
using System.Linq;


namespace Square_Numbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbersList = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                double squareNumber = Math.Sqrt(numbersList[i]);
                if (squareNumber == (int)squareNumber)
                {
                    squareNumbersList.Add(numbersList[i]);
                }
            }
            squareNumbersList.Sort();
            squareNumbersList.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbersList));
        }
    }
}
