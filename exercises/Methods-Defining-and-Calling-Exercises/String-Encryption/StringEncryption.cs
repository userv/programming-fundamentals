using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace String_Encryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result=string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter =char.Parse(Console.ReadLine()) ;
                string encrypted= Encrypt(letter);
                result += encrypted;
            }
            Console.WriteLine(result);
        }

        static string Encrypt(char letter)
        {
            string result = string.Empty;
            int asciiCode = (int) letter;
            int lastDigit = asciiCode%10;
            
            int firstDigit = 0;
            while (asciiCode >= 10)
            {
                asciiCode /= 10;
            }
            firstDigit = asciiCode % 10;
            asciiCode = (int) letter;
            char start = (char)(asciiCode + lastDigit);
            string middle = firstDigit.ToString()+ lastDigit.ToString();
            char end =(char) (asciiCode - firstDigit);
            result = start + middle + end;

            return result;
        }
    }
}
