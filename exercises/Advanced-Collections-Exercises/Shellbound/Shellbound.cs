using System;
using System.Collections.Generic;
using System.Linq;


namespace Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            Dictionary<string,HashSet<int>> shells=new Dictionary<string, HashSet<int>>();
            string inputLine = string.Empty;
            while (inputLine!= "Aggregate")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "Aggregate") continue;
                string[] tokens = inputLine.Split(' ');
                string region = tokens[0];
                int shellSize = int.Parse(tokens[1]);
                AddShell(shells, region, shellSize);
            }
            PrintShells(shells);
        }

        public static void PrintShells(Dictionary<string, HashSet<int>> shells)
        {
            foreach (var region in shells)
            {
                int sum = region.Value.Sum();
                int count = region.Value.Count;
                int giantShell = sum - sum / count;
                Console.WriteLine($"{region.Key} -> { string.Join(", ", region.Value)} ({giantShell})");
            }
        }

        public static void AddShell(Dictionary<string, HashSet<int>> shells, string region, int shellSize)
        {
            if (!shells.ContainsKey(region))
            {
                shells[region]=new HashSet<int>();
            }
            shells[region].Add(shellSize);
        }
    }
}
