using System;
using System.Collections.Generic;

namespace _1.Serialize_String
{
    public class SerializeString
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<char, List<int>> charIndexes = new Dictionary<char, List<int>>();
            foreach (var ch in inputLine)
            {
                if (!charIndexes.ContainsKey(ch))
                {
                    int index = 0;
                    charIndexes.Add(ch, new List<int>());
                    while (index != -1)
                    {
                        index = inputLine.IndexOf(ch.ToString(), index);
                        if (index != -1)
                        {
                            charIndexes[ch].Add(index);
                            index++;
                        }
                    }
                }
            }
            foreach (var ch in charIndexes)
            {
                Console.WriteLine($"{ch.Key}:{string.Join("/", ch.Value)}");
            }
        }
    }
}
