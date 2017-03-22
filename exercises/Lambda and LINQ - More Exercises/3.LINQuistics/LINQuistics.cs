using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            Dictionary<string,List<string>> colections=new Dictionary<string, List<string>>();
            string inputLine = Console.ReadLine();
            while (inputLine!="exit")
            {
                string[] tokens =
                    inputLine.Split(new char[] {' ', '(', ')', '.'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string colectionName = tokens[0];
                if (tokens.Length>1)
                {
                    
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        string method = tokens[i];
                        if (!colections.ContainsKey(colectionName))
                        {
                            colections.Add(colectionName,new List<string>());
                        }
                        colections[colectionName].Add(method);
                    }
                }
                else
                {
                    if (colections.ContainsKey(colectionName))
                    {
                        //var ordered = from s in colections[colectionName]
                        //    orderby  s.Length descending 
                        //    select s;
                        var ordered = colections[colectionName]
                            .OrderByDescending(x => x.Length)
                            .ThenByDescending(x => x.Distinct().Count());

                        foreach (var method in ordered)
                        {
                                Console.WriteLine($"* {method}");
                        }
                    }
                    int n = 0;
                    if (int.TryParse(tokens[0],out n))
                    {
                        var orderedByN = colections.Values
                            .OrderBy(x => x.Max())
                            .Take(1);//ToDictionary(k => colections.Keys ,v => colections.Values );

                       // var order = orderedByN.OrderBy(method => method.OrderBy(x => x.Length));
                       List<string> orderedMethods=new List<string>();
                        foreach (var method in orderedByN)
                        {
                            orderedMethods = method.OrderBy(x => x.Length).Take(n).ToList();
                        }
                        foreach (var method in orderedMethods)
                        {
                            Console.WriteLine($"* {method}");
                        }
                       

                    }
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
