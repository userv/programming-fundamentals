using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camels_Back
{
  public  class CamelsBack
    {
        public static void Main()
        {
            List<int> buildingsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelbackSize = int.Parse(Console.ReadLine());
            if (buildingsList.Count==camelbackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ",buildingsList)}");
                return;
            }
            int rounds = 0;
            while (buildingsList.Count!=camelbackSize)
            {
                buildingsList.RemoveAt(0);
                buildingsList.RemoveAt(buildingsList.Count-1);
                rounds++;
            }
            Console.WriteLine($"{rounds} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", buildingsList)}");
        }
    }
}
