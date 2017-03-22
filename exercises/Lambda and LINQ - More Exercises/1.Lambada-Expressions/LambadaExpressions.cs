using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Lambada_Expressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "lambada")
            {
                string[] tokens =
                    inputLine.Split(new char[] {' ','=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length > 1)
                {
                    string selector = tokens[0];
                    string selectorObject = tokens[1];
                    string property = tokens[2];
                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions.Add(selector,new Dictionary<string, string>());
                    }
                    lambadaExpressions[selector][selectorObject] = property;
                }
                else if (tokens[0]=="dance")
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                            .ToDictionary(selectorObject => selectorObject.Key,
                                selectorObject => selectorObject.Key + "." + selectorObject.Value));

                }
                inputLine = Console.ReadLine();
            }
            foreach (var selector in lambadaExpressions)
            {

                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }

            }

        }
    }
}
