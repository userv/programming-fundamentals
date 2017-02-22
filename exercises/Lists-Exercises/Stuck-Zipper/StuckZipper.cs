using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck_Zipper
{
    public class StuckZipper
    {
        public static int minNumberOfDigits = 0;
        public static int insertAtPosition = 1;
        public static void Main()
        {
            List<int> numbersList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbersList2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            minNumberOfDigits = CheckMinNumbersOfDigits(numbersList1, numbersList2);
            RemoveBadElements(numbersList1);
            RemoveBadElements(numbersList2);
            ZipLists(numbersList1, numbersList2);
            Console.WriteLine(string.Join(" ", numbersList2));

        }

        private static void ZipLists(List<int> numbersList1, List<int> numbersList2)
        {
            if (numbersList1.Count==0) return;
            for (int i = 0; i < numbersList1.Count; i++)
            {
                if (insertAtPosition>numbersList2.Count)
                {
                    numbersList2.Add(numbersList1[i]);
                }
                else
                {
                    numbersList2.Insert(insertAtPosition, numbersList1[i]);
                    insertAtPosition += 2;
                }
            }
           
        }

        public static void RemoveBadElements(List<int> numbersList)
        {
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (NumberOfDigits(numbersList[i]) > minNumberOfDigits)
                {
                    numbersList.RemoveAt(i);
                    i = -1;
                }
            }
        }

        public static int CheckMinNumbersOfDigits(List<int> numbersList1, List<int> numbersList2)
        {
            int result = int.MaxValue;
            foreach (var num in numbersList1)
            {
                int digits = NumberOfDigits(num);
                if (digits < result)
                {
                    result = digits;
                }
            }
            foreach (var num in numbersList2)
            {
                int digits = NumberOfDigits(num);
                if (digits < result)
                {
                    result = digits;
                }
            }

            return result;
        }

        public static int NumberOfDigits(int num)
        {
            int digits = (Math.Abs(num)).ToString().Length;
            return digits;
        }
    }
}
