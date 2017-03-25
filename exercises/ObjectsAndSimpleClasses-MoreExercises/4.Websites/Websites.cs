using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Websites
{
    class Websites
    {
        public class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries = new List<string>();
        }

        public static Website AddWebsite(string websiteData)
        {
            string[] tokens = websiteData.Split(new char[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string host = tokens[0];
            string domain = tokens[1];
            List<string> queries = tokens.Skip(2).ToList();
            Website website = new Website
            {
                Host = host,
                Domain = domain,
                Queries = queries
            };
            return website;
        }
        static void Main(string[] args)
        {
            List<Website> websites = new List<Website>();
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                websites.Add(AddWebsite(inputLine));
                inputLine = Console.ReadLine();
            }
            foreach (var website in websites)
            {
                if (website.Queries.Count < 1)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
                else
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=");
                    for (int i = 0; i < website.Queries.Count; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write($"[{website.Queries[i]}]");
                        }
                        else
                        {
                            Console.Write($"&[{website.Queries[i]}]");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
