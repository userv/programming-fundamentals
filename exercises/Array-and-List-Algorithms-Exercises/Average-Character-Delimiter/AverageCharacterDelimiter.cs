using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Character_Delimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            string[] stringsArray = Console.ReadLine().Split(' ').ToArray();

            int sum = CalculateSumOfCharacters(stringsArray);
            char delimeter =(char) (sum);
            Console.WriteLine(string.Join(delimeter.ToString().ToUpper(),stringsArray));
        }

        public static int CalculateSumOfCharacters(string[] stringsArray)
        {
            int sum=0;
            int countOfLetters = 0;
            for (int i = 0; i < stringsArray.Length; i++)
            {
                string currentString = stringsArray[i];
                for (int j = 0; j < currentString.Length; j++)
                {
                    sum += currentString[j];
                    countOfLetters++;
                }
            }
            return sum/countOfLetters;
        }
    }
}
 