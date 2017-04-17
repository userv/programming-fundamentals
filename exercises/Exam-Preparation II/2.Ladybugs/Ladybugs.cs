using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            int[] ladybugsIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            foreach (var index in ladybugsIndexes)
            {
                if (index >= size || index < 0)
                {
                    continue;
                }
                field[index] = 1;

            }
            string command = string.Empty;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    continue;
                }
                string[] commands = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int ladybugIndex = int.Parse(commands[0]);
                if (ladybugIndex >= size || ladybugIndex < 0)
                {
                    continue;
                }
                string direction = commands[1];
                int flylength = int.Parse(commands[2]);
                //    if (flylength >= size) continue;
                int currentPosition = ladybugIndex;
                if (field[ladybugIndex] == 0)
                {
                    continue;
                }
                field[ladybugIndex] = 0;
                while (true)
                {
                    if (direction == "right")
                    {
                        currentPosition += flylength;
                    }
                    else
                    {
                        currentPosition -= flylength;
                    }
                    if (currentPosition >= size || currentPosition < 0)
                    {
                        break;
                    }
                    if (field[currentPosition] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[currentPosition] = 1;
                        break;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", field));

        }
    }
}
