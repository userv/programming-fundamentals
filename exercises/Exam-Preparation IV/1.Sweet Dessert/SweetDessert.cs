using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sweet_Dessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            long numberOfGuests = long.Parse(Console.ReadLine());
            double priceOfBananas = double.Parse(Console.ReadLine());
            double priceOfEggs = double.Parse(Console.ReadLine());
            double priceOfBerries = double.Parse(Console.ReadLine());
            long numberOfSets = 0L;
            if ((numberOfGuests % 6) == 0)
            {
                numberOfSets = numberOfGuests / 6;
            }
            else
            {
                numberOfSets = numberOfGuests / 6 + 1;
            }
            decimal totalPrice = (decimal) (numberOfSets * (2 * priceOfBananas) + numberOfSets * (4 * priceOfEggs) +
                                 numberOfSets * (0.2 * priceOfBerries));
            if (totalPrice<=amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                decimal neededMoney = Math.Abs(totalPrice - amountOfCash);
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }

        }
    }
}
