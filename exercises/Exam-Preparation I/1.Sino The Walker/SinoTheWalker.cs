using System;
using System.Globalization;

namespace _1.Sino_The_Walker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            string timeFormat = @"hh\:mm\:ss";
            string time = Console.ReadLine();
            int steps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
            TimeSpan leavingTime = TimeSpan.ParseExact(time,timeFormat,CultureInfo.InvariantCulture);
            int secondsInADay = 60 * 60 * 24;
            int totalSecondsNeeded = (int) (((double) steps * secondsPerStep) % secondsInADay);
            var arrivalTime = leavingTime.Add(new TimeSpan(0,0,totalSecondsNeeded));
            //Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", leavingTime);
            Console.WriteLine("Time Arrival: {0}", arrivalTime.ToString(timeFormat));

        }
    }
}
 