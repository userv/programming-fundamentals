using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string command = string.Empty;
            while (command != "done")
            {
                command = Console.ReadLine();
                printElement(command, names, phoneNumbers);
            }
        }

        public static void printElement(string command, string[] names, string[] phoneNumbers)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (command == names[i])
                {
                    Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                }
            }
        }
    }
}
