using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ununion_Lists
{
   public class UnunionLists
    {
        public static void Main()
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> integerList=new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                integerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                RemoveAllOccurrences(primalList, integerList);
                primalList.AddRange(integerList);
            }
            
            primalList.Sort();
            Console.WriteLine(string.Join(" ",primalList));

        }

        public static void RemoveAllOccurrences(List<int> primalList, List<int> integerList)
        {
            for (int i = 0; i < integerList.Count; i++)
            {
                bool removeElement = false;
                int number = integerList[i];
                while(primalList.IndexOf(number) != -1)
                {
                    int index = primalList.IndexOf(number);
                    primalList.RemoveAt(index);
                    removeElement = true;
                }
                if (removeElement)
                {
                    integerList.RemoveAt(i);
                    i = -1;
                }
                
            }
            
        }
    }
}
