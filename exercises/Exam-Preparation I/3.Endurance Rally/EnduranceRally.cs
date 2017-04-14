using System;
using System.Linq;


namespace _3.Endurance_Rally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            string[] driversNames = Console.ReadLine().Split(' ').ToArray();
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in driversNames)
            {
                double fuel = (double)driver[0];
                int reachedZone = 0;
                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel <= 0)
                    {
                        reachedZone = i;
                        break;
                    }
                }
                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {reachedZone}");
                }
                else
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
