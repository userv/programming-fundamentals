using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Largest_3_Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(d => double.Parse(d))
                .OrderByDescending(d => d)
                .Take(3)
                .ToList();
           Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
