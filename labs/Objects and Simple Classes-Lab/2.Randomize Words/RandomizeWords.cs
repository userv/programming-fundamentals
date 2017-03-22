using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
   public  class RandomizeWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random random=new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int wordPos = random.Next(0,words.Length);
                string tempString = words[i];
                words[i] = words[wordPos];
                words[wordPos] = tempString;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
