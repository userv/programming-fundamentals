using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Elements_Equal_to_Their_Index
{
    class ArrayElementsEqualTheirIndex
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i]==i)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
