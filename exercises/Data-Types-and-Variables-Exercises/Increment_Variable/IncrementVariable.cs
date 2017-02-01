using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            byte byteVariable=0;
            int overflows = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                byteVariable++;
                if (byteVariable==0)
                {
                    overflows++;

                }
                
            }
            if (overflows==0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("{0}",n - ((byte.MaxValue + 1) * overflows));
                Console.WriteLine("Overflowed {0} times",overflows);
            }
            
        }
    }
}
