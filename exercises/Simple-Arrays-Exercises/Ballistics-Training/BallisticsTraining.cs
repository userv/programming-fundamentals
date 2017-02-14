using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballistics_Training
{
    public class BallisticsTraining
    {
        public static void Main()
        {
            int[] targetCoordinatesXY = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commandsArray = Console.ReadLine().Split(' ').ToArray();
            int projectileX = 0;
            int projectileY = 0;
            for (int i = 0; i < commandsArray.Length - 1; i += 2)
            {
                string command = commandsArray[i];
                int num = int.Parse(commandsArray[i + 1]);
                switch (command)
                {
                    case "up":
                        projectileY += num;
                        break;
                    case "down":
                        projectileY -= num;
                        break;
                    case "left":
                        projectileX -= num;
                        break;
                    case "right":
                        projectileX += num;
                        break;
                }
            }
            bool isHit = (targetCoordinatesXY[0] == projectileX) && (targetCoordinatesXY[1] == projectileY);
            if (isHit)
            {
                Console.WriteLine($"firing at [{projectileX}, {projectileY}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{projectileX}, {projectileY}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
