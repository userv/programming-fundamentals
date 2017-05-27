using System;
using System.Linq;

namespace _03.Wormhole
{
    public class Wormhole
    {
        public static void Main()
        {
            int[] wormholes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int steps = 0;
            int currentIndex = 0;
            int lastIndex = wormholes.Length - 1;
            while (currentIndex <= lastIndex)
            {
                if (wormholes[currentIndex] == 0)
                {
                    currentIndex++;
                    steps++;
                }
                else
                {
                    int tmp = wormholes[currentIndex];
                    wormholes[currentIndex] = 0;
                    currentIndex = tmp;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
