using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.CottageScraper
{
    public class CottageScaper
    {
        public static void Main()
        {
            Dictionary<string, List<int>> trees = new Dictionary<string, List<int>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "chop chop")
            {
                string[] tokens = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string treeType = tokens[0];
                int treeLength = int.Parse(tokens[1]);
                if (!trees.ContainsKey(treeType))
                {
                    trees.Add(treeType, new List<int>());
                }
                trees[treeType].Add(treeLength);
                inputLine = Console.ReadLine();
            }
            string neededType = Console.ReadLine();
            int neededHeight = int.Parse(Console.ReadLine());

            int sumOfAllLogs = 0;
            int countOfAllLogs = 0;
            int usedLogs = 0;
            foreach (var logs in trees)
            {
                sumOfAllLogs += logs.Value.Sum();
                countOfAllLogs += logs.Value.Count;
            }
            var usedTrees = trees
                     .Where(x => x.Key == neededType)
                    .ToDictionary(x => x.Key, x => x.Value);
            foreach (var log in usedTrees.Values)
            {
                usedLogs = log.Where(x => x >= neededHeight).Sum();
            }

            int unusedLogs = sumOfAllLogs - usedLogs;
            double pricePerMeter = Math.Round((double)sumOfAllLogs / countOfAllLogs, 2);
            double usedLogsPrice = Math.Round(usedLogs * pricePerMeter,2);
            double unusedLogsPrice = Math.Round(unusedLogs * pricePerMeter * 0.25,2);
            double subTotal = Math.Round(usedLogsPrice + unusedLogsPrice,2);
            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${subTotal:F2}");

        }
    }
}
