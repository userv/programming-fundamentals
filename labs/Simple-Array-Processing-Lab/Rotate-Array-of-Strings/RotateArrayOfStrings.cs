using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_of_Strings
{
   public class RotateArrayOfStrings
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            string[] rotatedArray=new string[strings.Length];
            rotatedArray[0] = strings[strings.Length-1];
            for (int i = 0; i < strings.Length-1; i++)
            {
                rotatedArray[i+1] = strings[i];
            }
            string result = string.Join(" ", rotatedArray);
            Console.WriteLine(result);



        }
    }
}
