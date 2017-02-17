using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Resizable_Array
{
   public class ResizableArray
    {
        public static int nextPosition = 0;
      public  static void Main()
        {
            int?[] intArray = new int?[] { null, null, null, null };
            string command = string.Empty;
            int number = 0;
            while (command != "end")
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                command = commands[0];
                switch (command)
                {
                    case "push":
                        number = int.Parse(commands[1]);
                        intArray = push(intArray, number);
                        break;

                    case "pop":
                        pop(intArray);
                        break;

                    case "removeAt":
                        number = int.Parse(commands[1]);
                        removeAt(intArray, number);
                        break;

                    case "clear":
                        clear(intArray);
                        break;
                }

            }

            if (isArrayEmpty(intArray))
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ", intArray));
            }
        }

        public static int?[] resizeArray(int?[] intArray)
        {
            int?[] resizedArray = new int?[intArray.Length * 2];
            for (int i = 0; i < resizedArray.Length; i++)
            {
                if (i < intArray.Length)
                {
                    resizedArray[i] = intArray[i];
                }
                else
                {
                    resizedArray[i] = null;
                }
            }

            return resizedArray;

        }

        public static bool isArrayEmpty(int?[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] != null)
                {
                    return false;
                }
            }
            return true;

        }

        public static void clear(int?[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = null;
            }
            nextPosition = 0;
        }

        public static void removeAt(int?[] intArray, int index)
        {
            if (index <= nextPosition)
            {
                for (int i = index; i <= nextPosition; i++)
                {
                    intArray[i] = intArray[i + 1];
                }
                nextPosition--;
            }
        }

        public static void pop(int?[] intArray)
        {
            if (!isArrayEmpty(intArray))
            {
                nextPosition--;
                intArray[nextPosition] = null;
            }
        }

        public static int?[] push(int?[] intArray, int number)
        {
            if (nextPosition < intArray.Length)
            {
                intArray[nextPosition] = number;
                nextPosition++;
            }
            else
            {
                intArray = resizeArray(intArray);
                intArray[nextPosition] = number;
                nextPosition++;

            }
            return intArray;
        }

    }
}
