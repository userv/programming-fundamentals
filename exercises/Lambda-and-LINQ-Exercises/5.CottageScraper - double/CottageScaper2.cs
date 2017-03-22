using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.CottageScraper
{
    public class CottageScaper
    {
        public static void Main()
        {
            Dictionary<string, List<double>> trees = new Dictionary<string, List<double>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "chop chop")
            {
                string[] tokens = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string treeType = tokens[0];
                double treeLength = double.Parse(tokens[1]);
                if (!trees.ContainsKey(treeType))
                {
                    trees.Add(treeType, new List<double>());
                }
                trees[treeType].Add(treeLength);
                inputLine = Console.ReadLine();
            }
            string neededType = Console.ReadLine();
            double neededHeight = double.Parse(Console.ReadLine());

            double sumOfAllLogs = 0;
            double countOfAllLogs = 0;
            double usedLogs = 0;
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

            double unusedLogs = sumOfAllLogs - usedLogs;
            double pricePerMeter = Math.Round((double)sumOfAllLogs / countOfAllLogs, 2);
            double usedLogsPrice = usedLogs * pricePerMeter;
            double unusedLogsPrice = unusedLogs * pricePerMeter * 0.25;
            double subTotal = usedLogsPrice + unusedLogsPrice;
            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${subTotal:F2}");

        }
    }
}
