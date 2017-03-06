using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    public class DictRef
    {
        public static void Main()
        {
            Dictionary<string, int> refDictionary = new Dictionary<string, int>();
            string inputLine = string.Empty;
            while (inputLine != "end")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "end") continue;
                string[] entry = inputLine
                    .Split(new char[] { '=' }, StringSplitOptions.None)
                    .ToArray();
                entry[0] = entry[0].Trim();
                entry[1] = entry[1].Trim();

                int value;
                bool success = int.TryParse(entry[1], out value);
                if (success)
                {
                    if (refDictionary.ContainsKey(entry[0]))
                    {
                        refDictionary[entry[0]] = value;
                    }
                    else
                    {
                        refDictionary.Add(entry[0], value);
                    }

                }
                else
                {
                    if (refDictionary.ContainsKey(entry[0]) && refDictionary.ContainsKey(entry[1]))
                    {
                        refDictionary[entry[0]] = refDictionary[entry[1]];
                    }
                    else if (!refDictionary.ContainsKey(entry[0]) && refDictionary.ContainsKey(entry[1]))
                    {
                        refDictionary.Add(entry[0], refDictionary[entry[1]]);
                    }
                }

            }
            foreach (var kvp in refDictionary)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");

            }
        }
    }
}
