using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _2.Fish_Statistics
{
    public class FishStatistics
    {
        public class Fish
        {
            public string FishString { get; set; }
            public int Tail { get; set; }
            public int Body { get; set; }
            public string Status { get; set; }

            public string GetTailType()
            {
                if (Tail > 5)
                {
                    return $"Long ({Tail * 2} cm)";
                }
                if (Tail > 1 && Tail <= 5)
                {
                    return $"Medium ({Tail * 2} cm)";
                }
                if (Tail == 1)
                {
                    return $"Short ({Tail * 2} cm)";
                }
                return "None";
            }
            public string GetBodyType()
            {
                if (Body > 10)
                {
                    return $"Long ({Body * 2} cm)";
                }
                if (Body > 5 && Body <= 10)
                {
                    return $"Medium ({Body * 2} cm)";
                }
                return $"Short ({Body * 2} cm)";
            }

            public string GetStatus()
            {
                if (Status == "'") return "Awake";
                if (Status == "-") return "Asleep";
                if (Status == "x") return "Dead";
                return Status;
            }

        }
        public static void Main()
        {
            List<Fish> fishes = new List<Fish>();
            string fishPattern = @"(>{1,})?<(\({1,})([\'|\-|x])([>])";
            string inputLine = Console.ReadLine();

            //Group 1.    159 - 161 `>>`
            //Group 2.    162 - 164 `((`
            //Group 3.    164 - 165 `'`
            //Group 4.    165 - 166 `>`

            Regex regex = new Regex(fishPattern);
            MatchCollection matches = regex.Matches(inputLine);
            if (matches.Count > 0)
            {
                foreach (Match fish in matches)
                {
                    Fish newFish = new Fish();
                    newFish.FishString = fish.Groups[0].Value;
                    if (fish.Groups[1].Value == "")
                    {
                        newFish.Tail = 0;
                        Console.WriteLine(fish.Groups[1].Value);
                    }
                    else
                    {
                        newFish.Tail = fish.Groups[1].Value.Length;
                    }
                    newFish.Body = fish.Groups[2].Value.Length;
                    newFish.Status = fish.Groups[3].Value;
                    fishes.Add(newFish);
                }
                int count = 1;
                foreach (var fish in fishes)
                {
                    Console.WriteLine($"Fish {count}: {fish.FishString}");
                    Console.WriteLine($"  Tail type: {fish.GetTailType()}");
                    Console.WriteLine($"  Body type: {fish.GetBodyType()}");
                    Console.WriteLine($"  Status: {fish.GetStatus()}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }


        }
    }
}
