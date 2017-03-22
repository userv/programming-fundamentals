using System;
using System.Globalization;


namespace _1.Day_of_Week
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string dateString = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt.DayOfWeek);
        }
    }
}
