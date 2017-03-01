using System;
using System.Linq;


namespace Sort_Array_of_Strings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ').ToArray();
            bool sorted = true;
            do
            {
                sorted = true;
                for (int i = 0; i < strings.Length - 1; i++)
                {
                    string temp = string.Empty;
                    int index = string.Compare(strings[i], strings[i + 1]);
                    if (index > 0)
                    {
                        temp = strings[i];
                        strings[i] = strings[i + 1];
                        strings[i + 1] = temp;
                        sorted = false;
                    }
                    

                }
            } while (!sorted);
            Console.WriteLine(string.Join(" ",strings));
        }
    }
}
