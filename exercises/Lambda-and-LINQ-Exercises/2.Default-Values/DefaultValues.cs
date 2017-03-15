using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Default_Values
{
    public class DefaultValues
    {
        public static void Main()
        {
            Dictionary<string,string> dictionary=new Dictionary<string, string>();
            string inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                string[] tokens =
                    inputLine.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                dictionary[tokens[0]] = tokens[1];
                inputLine = Console.ReadLine();
            }
            string defaultValue = Console.ReadLine();
            var sortedDict = dictionary.Where(x => x.Value != "null")
                .ToDictionary(x => x.Key, x => x.Value)
                .OrderByDescending(x => x.Value.Length);
            var replasedDict = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var entry in sortedDict)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }
            foreach (var entry in replasedDict)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }
           
        }
    }
}