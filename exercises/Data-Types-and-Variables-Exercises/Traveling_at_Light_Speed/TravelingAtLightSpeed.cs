using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_at_Light_Speed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYearInKm = 9450000000000m;
            decimal speedOfLightPerSecond = 300000m;
            decimal lightYears = decimal.Parse(Console.ReadLine());
            lightYears*=lightYearInKm;
            decimal timeToTravelSeconds = lightYears/speedOfLightPerSecond;
            
            TimeSpan ts = TimeSpan.FromSeconds((double) timeToTravelSeconds);

            Console.WriteLine("{0} weeks",ts.Days/7);
            Console.WriteLine("{0} days", ts.Days % 7);
            Console.WriteLine("{0} hours", ts.Hours);
            Console.WriteLine("{0} minutes", ts.Minutes);
            Console.WriteLine("{0} seconds", ts.Seconds);

        }
    }
}
