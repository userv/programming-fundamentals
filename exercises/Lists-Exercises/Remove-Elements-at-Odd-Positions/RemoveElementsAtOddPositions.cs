using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = Console.ReadLine().Split(' ').ToList();
            List<string> oddElementsList=new List<string>();
            for (int i = 0; i < stringList.Count; i++)
            {
                if ((i+1)%2==0)
                {
                    oddElementsList.Add(stringList[i]);
                }
            }
            Console.WriteLine(string.Join("",oddElementsList));
        }
    }
}
