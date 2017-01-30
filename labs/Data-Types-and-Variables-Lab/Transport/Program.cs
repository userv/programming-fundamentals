using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 4 + 8 + 12;
            int n = int.Parse(Console.ReadLine());
            int courses = (int) Math.Ceiling((double) n/capacity);
            Console.WriteLine(courses);
        }
    }
}
