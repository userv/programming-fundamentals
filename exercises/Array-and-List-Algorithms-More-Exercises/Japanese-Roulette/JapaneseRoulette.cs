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
            int currentPos = 0;
            for (int i = 0; i < playersList.Count; i++)
            {
                string[] playerParams = playersList[i].Split(',').ToArray();
                string direction = playerParams[0];
                int strenght = int.Parse(playerParams[1]);


            }

        }
    }
}
