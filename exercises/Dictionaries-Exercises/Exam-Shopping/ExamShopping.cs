using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Shopping
{
    public class ExamShopping
    {
        public static List<string> log = new List<string>();
        public static void Main()
        {
            SortedDictionary<string, int> shopInventory = new SortedDictionary<string, int>();
            string inputLine = string.Empty;
            
            while (inputLine != "exam time")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "exam time") continue;
                string[] args = inputLine.Split(' ').ToArray();
                if (args.Length < 3) continue;
                string command = args[0];
                string inventory = args[1];
                int quantity = int.Parse(args[2]);

                switch (command)
                {
                    case "stock":
                        StockInventory(shopInventory, inventory, quantity);
                        break;
                    case "buy":
                        BuyInventory(shopInventory, inventory, quantity);
                        break;
                }
            }
            
            PrintInventory(shopInventory);
        }

        public static void PrintInventory(SortedDictionary<string, int> shopInventory)
        {
            if (log.Count>0)
            {
                foreach (var message in log)
                {
                    Console.WriteLine(message);
                }
            }
            foreach (var kvp in shopInventory)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }

        public static void BuyInventory(SortedDictionary<string, int> shopInventory, string inventory, int quantity)
        {
            if (!shopInventory.ContainsKey(inventory))
            {
                Console.WriteLine($"{inventory} doesn't exist");
               // log.Add($"{inventory} doesn't exist");
                return;
            }
            if (shopInventory[inventory]==0)
            {
                Console.WriteLine($"{inventory} out of stock");
            }
            if (shopInventory[inventory] - quantity <= 0)
            {
                shopInventory[inventory] = 0;
            }
            else
            {
                shopInventory[inventory] -= quantity;
            }
        }

        public static void StockInventory(SortedDictionary<string, int> shopInventory, string inventory, int quantity)
        {
            if (!shopInventory.ContainsKey(inventory))
            {
                shopInventory.Add(inventory, quantity);
            }
            else
            {
                shopInventory[inventory] += quantity;
            }

        }
    }
}
