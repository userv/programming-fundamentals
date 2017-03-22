using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Ordered_Banking_System
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            Dictionary<string , Dictionary<string , decimal>> banks=new Dictionary<string, Dictionary<string, decimal>>();
            string inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                string[] tokens = inputLine.Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length<3) continue;
                string bankName = tokens[0];
                string accountName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);
                if (!banks.ContainsKey(bankName))
                {
                    banks.Add(bankName,new Dictionary<string, decimal>());
                }
                if (!banks[bankName].ContainsKey(accountName))
                {
                    banks[bankName].Add(accountName,0);
                }
                banks[bankName][accountName]+=balance;
                inputLine = Console.ReadLine();
            }
              var  orderedBanks=banks.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value));

            foreach (var bank in orderedBanks)
            {
                foreach (var account in bank.Value)
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }
        }
    }
}
