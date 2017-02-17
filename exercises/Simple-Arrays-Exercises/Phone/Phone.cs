using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                string[] commandStrings = Console.ReadLine().Split(' ').ToArray();
                command = commandStrings[0];
                string phone = string.Empty;
                if (command != "done")
                {
                    phone = commandStrings[1];
                }
                switch (command)
                {
                    case "call":
                        callNumber(phone, names, phoneNumbers);
                        break;
                    case "message":
                        messageToNumber(phone, names, phoneNumbers);
                        break;

                }
                //  printElement(command, names, phoneNumbers);
            }
        }

        public static void callNumber(string phone, string[] names, string[] phoneNumbers)
        {
            string nameNumber = getNameNumber(phone, names, phoneNumbers);
            string phoneNumber = getPhoneNumber(phone, names, phoneNumbers);
            Console.WriteLine($"calling {nameNumber}...");
            int sum = sumOfDigits(phoneNumber);
            if (sum % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                int minutes = sum / 60;
                int seconds = sum % 60;
                Console.WriteLine("call ended. duration: {0:00}:{1:00}",minutes,seconds);
            }

        }

        public static string getPhoneNumber(string phone, string[] names, string[] phoneNumbers)
        {
            string phoneNumber = string.Empty;
            bool isLetter = (phone[0] >= 65 && phone[0] <= 90) || (phone[0] >= 97 && phone[0] <= 122);
            if (isLetter)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == phone)
                    {
                        phoneNumber = phoneNumbers[i];
                        return phoneNumber;
                    }
                }
            }

            return phone;
        }

        public static int sumOfDigits(string phone)
        {
            int sum = 0;
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] >= 48 && phone[i] <= 57)
                {
                    sum += int.Parse(phone[i].ToString());
                }
            }
            return sum;

        }
        public static int differenceOfDigits(string phone)
        {
            int diff = 0;
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] >= 48 && phone[i] <= 57)
                {
                    diff -= int.Parse(phone[i].ToString());
                }
            }
            return Math.Abs(diff);

        }

        public static void messageToNumber(string phone, string[] names, string[] phoneNumbers)
        {
            string nameNumber = getNameNumber(phone, names, phoneNumbers);
            string phoneNumber = getPhoneNumber(phone, names, phoneNumbers);
            Console.WriteLine($"sending sms to {nameNumber}...");
            int diff = differenceOfDigits(phoneNumber);
            if (diff % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        public static string getNameNumber(string phone, string[] names, string[] phoneNumbers)
        {
            string result = string.Empty;
            bool isLetter = (phone[0] >= 65 && phone[0] <= 90) || (phone[0] >= 97 && phone[0] <= 122);
            if (isLetter)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == phone)
                    {
                        result = phoneNumbers[i];
                        return result;
                    }
                }
            }
            else
            {
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    if (phoneNumbers[i] == phone)
                    {
                        result = names[i];
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
