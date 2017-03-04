using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japanese_Roulette
{
    public class JapaneseRoulette
    {
        public static void Main(string[] args)
        {
            byte[] cylinder = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            List<string> playersList = Console.ReadLine().Split(' ').ToList();
            int currentPos = 2;
            bool isEverybodyGotLucky = true;
            for (int i = 0; i < playersList.Count; i++)
            {
                string[] playerParams = playersList[i].Split(',').ToArray();
                string direction = playerParams[1].ToLower();
                int strength = int.Parse(playerParams[0]);
                if (direction == "right")
                {

                    
                    while (strength > 0)
                    {
                        currentPos--;
                        if (currentPos < 0)
                        {
                            currentPos = cylinder.Length - 1;
                        }
                        strength--;
                    }
                    if (cylinder[currentPos] == 1)
                    {
                        Console.WriteLine($"Game over! Player {i} is dead.");
                        isEverybodyGotLucky = false;
                        break;
                    }
                  
                }
                if (direction == "left")
                {
                    
                    while (strength > 0)
                    {
                        currentPos++;
                        if (currentPos > cylinder.Length - 1)
                        {
                            currentPos = 0;
                        }
                        strength--;

                    }
                    if (cylinder[currentPos] == 1)
                    {
                        Console.WriteLine($"Game over! Player {i} is dead.");
                        isEverybodyGotLucky = false;
                        break;
                    }
                   
                }
                currentPos--;
                if (currentPos<0)
                {
                    currentPos = cylinder.Length - 1;
                }

            }
            if (isEverybodyGotLucky)
            {
                Console.WriteLine("Everybody got lucky!");
            }

        }
    }
}
