using System;
using System.Linq;


namespace _4.Sentence_Split
{
    public class SentenceSplit
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string[] delimiter = Console.ReadLine().Split();
            string[] elements = sentence.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
         //   elements = elements.Select(x => x.Trim()).ToArray();
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = elements[i].Trim();
            }
            Console.WriteLine($"[{string.Join(", ", elements)}]");
        
        }
    }
}
