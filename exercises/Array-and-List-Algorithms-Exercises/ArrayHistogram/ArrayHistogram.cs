using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main()
        {
            string[] stringsArray = Console.ReadLine().Split(' ').ToArray();
            List<string> wordsList=new List<string>();
            List<int> counts = new List<int>();
            for (int i = 0; i < stringsArray.Length; i++)
            {
                if (!wordsList.Contains(stringsArray[i]))
                {
                    wordsList.Add(stringsArray[i]);

                }
            }


        }
    }
}
