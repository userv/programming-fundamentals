using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    public class SalesReport
    {
        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

        static Sale ReadSale()
        {
            string[] sale = Console.ReadLine().Split(' ').ToArray();
            Sale newSale = new Sale()
            {
                Town = sale[0],
                Product = sale[1],
                Price = decimal.Parse(sale[2]),
                Quantity = decimal.Parse(sale[3])
            };
            return newSale;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach (var town in towns)
            {
                decimal salesByTown = sales
                    .Where(t => t.Town == town)
                    .Select(s => s.Price * s.Quantity)
                    .Sum();
                Console.WriteLine($"{town} -> {salesByTown:F2}");

            }

        }
    }
}
