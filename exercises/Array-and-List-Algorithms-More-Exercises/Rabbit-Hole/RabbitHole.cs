using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_Hole
{
    public class RabbitHole
    {
        public static int currentPos = 0;
        public static void Main()
        {
            List<string> obstaclesList = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            ProcessObstacles(obstaclesList, energy);

        }

        public static void ProcessObstacles(List<string> obstaclesList, int energy)
        {
            while (energy > 0)
            //for (int i = 0; i < obstaclesList.Count; i++)
            {
                if (obstaclesList[currentPos] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else
                {
                    string[] obstacles = obstaclesList[currentPos].Split('|').ToArray();
                    if (obstacles[0].ToLower() == "right")
                    {
                        int jumps = int.Parse(obstacles[1]);
                        currentPos = (currentPos + jumps) % obstaclesList.Count;

                        energy -= jumps;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }

                    }
                    if (obstacles[0].ToLower() == "left")
                    {
                        int jumps = int.Parse(obstacles[1]);
                        currentPos = Math.Abs(currentPos - jumps) % obstaclesList.Count;
                        energy -= jumps;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }
                    }
                    if (obstacles[0].ToLower() == "bomb")
                    {
                        int damage = int.Parse(obstacles[1]);
                        energy -= damage;
                        obstaclesList.RemoveAt(currentPos);
                        currentPos = 0;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                    }

                }
                if (obstaclesList[obstaclesList.Count - 1] == "RabbitHole")
                {
                    obstaclesList.Add($"Bomb|{energy}");
                }
                else
                {
                    obstaclesList.RemoveAt(obstaclesList.Count - 1);
                    obstaclesList.Add($"Bomb|{energy}");
                }


            }

        }
    }
}
