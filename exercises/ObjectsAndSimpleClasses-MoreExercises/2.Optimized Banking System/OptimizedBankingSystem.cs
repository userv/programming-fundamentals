using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Optimized_Banking_System
{
    public class OptimizedBankingSystem
    {
        public class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }

        }
        public static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>();
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] tokens =
                    inputLine.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length < 3) continue;
                string Bank = tokens[0];
                string Name = tokens[1];
                decimal Balance = decimal.Parse(tokens[2]);
                if (accounts.Where(b => b.Bank==Bank).Any(n =>n.Name.Contains(Name)))
                {

                    var currentAccount = accounts
                             .Where(n => n.Name == Name).AsEnumerable()
                             .Where(bank => bank.Bank == Bank)
                             .Select(b => b.Balance += Balance).ToList();
                }
                else
                {
                    BankAccount account = new BankAccount()
                    {
                        Name = Name,
                        Bank = Bank,
                        Balance = Balance
                    };
                    accounts.Add(account);
                }
                inputLine = Console.ReadLine();
            }
            var orderedAccount = accounts.OrderByDescending(b => b.Balance).ThenBy(n=>n.Bank.Length);
            foreach (var account in orderedAccount)
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }
    }
}
