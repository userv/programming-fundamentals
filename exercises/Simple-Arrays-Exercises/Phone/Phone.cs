using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string command = string.Empty;
            while (command != "done")
            {
                string[] commandStrings= Console.ReadLine().Split(' ').ToArray();
                command = commandStrings[0];
                string phone = commandStrings[1];
                switch (command)
                {
                    case "call":
                        callNumber(phone);
                        break;
                    case "message":
                        messageToNumber(phone);
                        break;

                }
              //  printElement(command, names, phoneNumbers);
            }
        }

        private static void messageToNumber(string phone)
        {
            
        }

        private static void callNumber(string phone)
        {
            
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
