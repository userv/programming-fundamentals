using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] topLeft = numbers.Take(k).Reverse().ToArray();
            int[] topRight = numbers.Reverse().Take(k).ToArray();
            int[] lowRow = numbers.Skip(k).Take(k * 2).ToArray();
            int[] topRow = topLeft.Concat(topRight).ToArray();
            var sumArr = topRow.Select((x, index) => x + lowRow[index]).ToArray();
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
