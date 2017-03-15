using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.Flatten_Dictionary
{
    public class Flatten_Dictionary
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> flattenDictionary = new Dictionary<string, string>();
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

        }
        
    }
}
