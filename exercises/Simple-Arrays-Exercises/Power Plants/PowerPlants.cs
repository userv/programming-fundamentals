using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Plants
{
    public class PowerPlants
    {
        public static void Main()
        {
            int[] powerLevel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool allDead = false;
            int numberOfPlants = powerLevel.Length;
            int seasonEnd = numberOfPlants;
            int plants=numberOfPlants;
            int days = 0;
            while (!allDead)
            {

                for (int i = 0; i < powerLevel.Length; i++)
                {
                     
                    if (powerLevel[i] != 0)
                    {
                        powerLevel[i]--;
                        if (i == days) powerLevel[i]++;
                    }
                    plants = livePlants(powerLevel);
                    if (plants==0)
                    {
                        allDead = true;
                        break;

                    }
                }
                if ((days%seasonEnd==0)&&(plants>0))
                {
                    bloom(powerLevel);
                }
                days++;
            }
            
        
        int seasons = days / numberOfPlants;
        Console.WriteLine($"survived {days} days ({seasons} seasons)");

        }

        public static void bloom(int[] powerLevel)
        {
            for (int i = 0; i < powerLevel.Length; i++)
            {
                if (powerLevel[i] > 0)
                {
                    powerLevel[i]++;
                }
            }
        }

        public static int livePlants(int[] powerLevel)
        {
            int livePlants = powerLevel.Length;
            for (int i = 0; i < powerLevel.Length; i++)
            {
                if (powerLevel[i]==0)
                {
                    livePlants--;
                }
            }
            return livePlants;
        }
}
}
