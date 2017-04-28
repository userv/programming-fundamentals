using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(' ').ToArray();
                string command = tokens[0];
                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);
                        array = ExchangeElements(array, index);
                        break;
                    case "max":
                        string evenOrOdd = tokens[1];
                        FindMaxElement(array, evenOrOdd);
                        break;
                    case "min":
                        evenOrOdd = tokens[1];
                        FindMinElement(array, evenOrOdd);
                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);
                        if (count > array.Length || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        evenOrOdd = tokens[2];
                        FindFirstElements(array, count, evenOrOdd);
                        break;
                    case "last":
                        count = int.Parse(tokens[1]);
                        if (count > array.Length || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        evenOrOdd = tokens[2];
                        FindLastElements(array, count, evenOrOdd);
                        break;

                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void FindLastElements(int[] array, int count, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int[] evenElements = array.Where(x => x % 2 == 0).ToArray();
                if (!evenElements.Any())
                {
                    Console.WriteLine("[]");
                    return;
                }
                int[] lastEvenElements = evenElements.Reverse().Take(count).Reverse().ToArray();
                Console.WriteLine($"[{string.Join(", ", lastEvenElements)}]");
            }
            else
            {
                int[] oddElements = array.Where(x => x % 2 == 1).ToArray();
                if (!oddElements.Any())
                {
                    Console.WriteLine("[]");
                    return;
                }
                int[] lastOddElements = oddElements.Reverse().Take(count).Reverse().ToArray();
                Console.WriteLine($"[{string.Join(", ", lastOddElements)}]");
            }
        }

        public static void FindFirstElements(int[] array, int count, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int[] evenElements = array.Where(x => x % 2 == 0).ToArray();
                if (!evenElements.Any())
                {
                    Console.WriteLine("[]");
                    return;
                }
                int[] firstEvenElements = evenElements.Take(count).ToArray();
                Console.WriteLine($"[{string.Join(", ", firstEvenElements)}]");
            }
            else
            {
                int[] oddElements = array.Where(x => x % 2 == 1).ToArray();
                if (!oddElements.Any())
                {
                    Console.WriteLine("[]");
                    return;
                }
                int[] firstOddElements = oddElements.Take(count).ToArray();
                Console.WriteLine($"[{string.Join(", ", firstOddElements)}]");
            }
        }

        public static void FindMinElement(int[] array, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int[] evenElements = array.Where(x => x % 2 == 0).ToArray();
                if (!evenElements.Any())
                {
                    Console.WriteLine("No matches");
                    return;
                }
                int index = Array.LastIndexOf(array, evenElements.Min());
                Console.WriteLine(index);
            }
            else
            {
                int[] oddElements = array.Where(x => x % 2 == 1).ToArray();
                if (!oddElements.Any())
                {
                    Console.WriteLine("No matches");
                    return;
                }
                int index = Array.LastIndexOf(array, oddElements.Min());
                Console.WriteLine(index);
            }
        }

        public static void FindMaxElement(int[] array, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int[] evenElements = array.Where(x => x % 2 == 0).ToArray();
                if (!evenElements.Any())
                {
                    Console.WriteLine("No matches");
                    return;
                }
                int index = Array.LastIndexOf(array, evenElements.Max());
                Console.WriteLine(index);
            }
            else
            {
                int[] oddElements = array.Where(x => x % 2 == 1).ToArray();
                if (!oddElements.Any())
                {
                    Console.WriteLine("No matches");
                    return;
                }
                int index = Array.LastIndexOf(array, oddElements.Max());
                Console.WriteLine(index);
            }
        }

        public static int[] ExchangeElements(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            int[] tempArray = array.Skip(index + 1).ToArray();
            array = array.Take(index + 1).ToArray();
            tempArray = tempArray.Concat(array).ToArray();
            return tempArray;
        }
    }
}
