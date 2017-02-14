using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] commandStrings = Console.ReadLine().Split(' ').ToArray();
            int altitude = int.Parse(commandStrings[0]);
            for (int i = 1; i < commandStrings.Length - 1; i+=2)
            {
                string command = commandStrings[i];
                int num = int.Parse(commandStrings[i + 1]);
                if (command == "up")
                {
                    altitude += num;
                }
                else if (command == "down")
                {
                    altitude -= num;
                }
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}
