using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Name
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
