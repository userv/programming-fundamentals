using System;
using System.Globalization;


namespace _1.SoftUni_Coffee_Orders
{
    public class CoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0M;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal price = ((daysInMonth * (long)capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
