using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Command_Interpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputLine = String.Empty;
            while (inputLine != "end")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    continue;
                }
                string[] tokens =inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(tokens[2]);
                        int reverseCount = int.Parse(tokens[4]);
                        if (IsValidParameters(array, reverseStart, reverseCount))
                        {
                            Reverse(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        int sortStart = int.Parse(tokens[2]);
                        int sortCount = int.Parse(tokens[4]);
                        if (IsValidParameters(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        int rollLeftCount = int.Parse(tokens[1]);
                        if (rollLeftCount >= 0)
                        {
                            RollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        int rollRightCount = int.Parse(tokens[1]);
                        if (rollRightCount >= 0)
                        {
                            RollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        public static bool IsValidParameters(List<string> array, int start, int count)
        {
            bool validParams = (start >= 0) && (start < array.Count)
                               && ((start + count) <= array.Count)
                               && (count >= 0);
            return validParams;
        }

        public static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }

        public static void Sort(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, null);
        }

        public static void RollLeft(List<string> array, int rollLeftCount)
        {
            int rotations = rollLeftCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = array[0];
                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Count - 1] = firstElement;
            }
        }
        public static void RollRight(List<string> array, int rollRightCount)
        {
            int rotations = rollRightCount % array.Count;
            for (int i = 0; i < rotations; i++)
            {
                string lastElement = array[array.Count - 1];
                for (int j = array.Count - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;
            }

        }

    }
}
