using System;

namespace _1.Charity_Marathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int runnersCount = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());
            int totalCapacity = trackCapacity * days;
            if (runnersCount > totalCapacity)
            {
                runnersCount = totalCapacity;
            }
            double totalKilometers = (double)runnersCount * averageLaps * lapLength / 1000;
            double totalMoney = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
