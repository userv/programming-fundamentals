using System;
using System.Collections.Generic;
using System.Linq;


namespace Dict_Ref_Advanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            Dictionary<string, List<int>> refDictionary = new Dictionary<string, List<int>>();
            string inputLine = string.Empty;
            while (inputLine != "end")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "end") continue;
                string[] entry = inputLine
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                AddToDictionary(entry, refDictionary);
            }
            PrintElements(refDictionary);

        }

        public static void PrintElements(Dictionary<string, List<int>> refDictionary)
        {
            foreach (var name in refDictionary)
            {
                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
            }
        }

        public static void AddToDictionary(string[] entry, Dictionary<string, List<int>> refDictionary)
        {
            entry[0] = entry[0].Trim();
            entry[1] = entry[1].Trim();
            int data;
            bool success = int.TryParse(entry[1][0].ToString(), out data);
            if (success)
            {
                List<int> list = entry[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
                if (refDictionary.ContainsKey(entry[0]))
                {
                    refDictionary[entry[0]].AddRange(list);
                }
                else
                {
                    refDictionary[entry[0]] = new List<int>();
                    refDictionary[entry[0]] = list;
                }
            }
            else
            {
                if (refDictionary.ContainsKey(entry[0]) && refDictionary.ContainsKey(entry[1]))
                {
                    //refDictionary[entry[0]].AddRange(refDictionary[entry[1]]); 
                    refDictionary[entry[0]]=new List<int>(refDictionary[entry[1]]);
                   // refDictionary[entry[0]] = refDictionary[entry[1]];
                }
                else if (!refDictionary.ContainsKey(entry[0]) && refDictionary.ContainsKey(entry[1]))
                {
                    refDictionary[entry[0]] = new List<int>(refDictionary[entry[1]]);
                    //refDictionary.Add(entry[0], refDictionary[entry[1]]);
                }
            }
        }
    }
}
