using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_Strings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string trickyString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                if (i==(n-1))
                {
                    trickyString += Console.ReadLine();
                }
                else
                {
                    trickyString += Console.ReadLine() + delimiter;
                }
            }
            Console.WriteLine(trickyString);
        }
    }
}
