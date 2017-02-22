using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tear_List_in_Half
{
    public class TearListInHalf
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> topList = new List<int>();
            int insertAtPosition = 0;
            SplitList(numbers, topList);
            for (int i = 0; i < topList.Count; i++)
            {
                int leftDigit = topList[i] / 10;
                int rightDigit = topList[i] % 10;
                numbers.Insert(insertAtPosition, leftDigit);
                numbers.Insert(insertAtPosition + 2, rightDigit);
                insertAtPosition += 3;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SplitList(List<int> numbers, List<int> topList)
        {
            int begin = numbers.Count / 2;
            int end = numbers.Count;
            for (int i = begin; i < end; i++)
            {
                topList.Add(numbers[i]);
            }
            numbers.RemoveRange(begin, numbers.Count / 2);
        }
    }
}
