using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Symmetry
{
    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ').ToArray();
            string[] reversedArray = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                reversedArray[i] = strings[(strings.Length - 1) - i];
            }
            bool isSymmetric = true;
            for (int i = 0; i < strings.Length; i++)
            {
                if (reversedArray[i] != strings[i])
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
