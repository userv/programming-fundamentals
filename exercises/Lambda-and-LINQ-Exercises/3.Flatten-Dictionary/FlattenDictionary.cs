﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.Flatten_Dictionary
{
    public class Flatten_Dictionary
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> flattenedDictionary = new Dictionary<string, string>();
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(' ');
                if (tokens[0] == "flatten")
                {
                    dictionary[tokens[1]] = dictionary[tokens[1]]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }
                else
                {
                    string key = tokens[0];
                    string innerKey = tokens[1];
                    string innerValue = tokens[2];
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }
                    dictionary[key][innerKey] = innerValue;
                }
                inputLine = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, string>> orderedDictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine($"{entry.Key}");
                Dictionary<string, string> orderedInnerDictionary = entry.Value
                     .Where(x => x.Value != "flattened")
                     .OrderBy(x => x.Key.Length)
                     .ToDictionary(x => x.Key, x => x.Value);

                flattenedDictionary = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);
                int count = 0;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    count++;
                    Console.WriteLine($"{count}. {innerEntry.Key} - {innerEntry.Value}");

                }
                foreach (var flattenedEntry in flattenedDictionary)
                {
                    count++;
                    Console.WriteLine($"{count}. {flattenedEntry.Key}");
                }

            }

        }

    }
}
