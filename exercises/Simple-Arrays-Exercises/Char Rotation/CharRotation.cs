using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Rotation
{
    public class CharRotation
    {
        public static void Main()
        {
            char[] charArray = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string message = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (numbers[i]%2!=0)
                {
                    message += (char) (charArray[i] + numbers[i]);
                }
                else
                {
                    message += (char) (charArray[i] - numbers[i]);
                }
            }
            Console.WriteLine(message);

        }
    }
}
