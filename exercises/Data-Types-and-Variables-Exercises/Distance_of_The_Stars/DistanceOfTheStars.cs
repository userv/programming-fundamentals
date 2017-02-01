using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_The_Stars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            decimal distanceToProxima = 4.22m;
            decimal distanceToCenterMilkyWay = 26000m;
            decimal diameterOfMilkyWay = 100000m;
            decimal distanceToTheEdgeOfGalaxy = 46500000000m;
            decimal lightYearInKilometers= 9450000000000m;

            Console.WriteLine((distanceToProxima * lightYearInKilometers).ToString("e2"));
            Console.WriteLine((distanceToCenterMilkyWay * lightYearInKilometers).ToString("e2"));
            Console.WriteLine((diameterOfMilkyWay * lightYearInKilometers).ToString("e2"));
            Console.WriteLine((distanceToTheEdgeOfGalaxy * lightYearInKilometers).ToString("e2"));
        }
    }
}
