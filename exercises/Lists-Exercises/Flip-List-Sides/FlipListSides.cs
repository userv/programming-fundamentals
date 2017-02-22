using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_List_Sides
{
    public class FlipListSides
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            if (numbers.Count%2==0)
            {
                count = numbers.Count/2;
            }
            else
            {
                count = (numbers.Count-1) / 2;
            }
            int lenght = numbers.Count - 1;
            for (int i = 1; i < count; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[lenght - i];
                numbers[lenght - i] = temp;

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
