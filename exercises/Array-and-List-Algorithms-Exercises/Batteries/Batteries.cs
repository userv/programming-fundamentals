using System;
using System.Linq;


namespace Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            double[] batteriesCapacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());
            for (int i = 0; i < batteriesCapacities.Length; i++)
            {
                string result=StressTestBattery(batteriesCapacities[i], usagePerHour[i],hours);
                Console.WriteLine($"Battery {i+1}: {result}");
            }


        }

        public static string StressTestBattery(double batteriesCapacities, double usagePerHour,int hours)
        {
            string result=string.Empty;
            if (batteriesCapacities>(usagePerHour*hours))
            {
                double remainingCapacity =batteriesCapacities - usagePerHour*hours;
                double percent = remainingCapacity/batteriesCapacities*100;
                result = $"{remainingCapacity:F2} mAh ({percent:F2})%";
            }
            else
            {
                int lasted =(int) Math.Ceiling(batteriesCapacities/usagePerHour);
                result = $"dead (lasted {lasted} hours)";

            }
            return result;
        }
    }
}
