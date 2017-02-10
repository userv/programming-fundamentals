using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = Proc(price, currentPrice);
            bool isSignificantDifference = isDifference(threshold, difference);
            string message = GetMessage(currentPrice, price, difference, isSignificantDifference);
            Console.WriteLine(message);
            price = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double price, double difference, bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({0:P})", price, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({0:P})", price, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({0:P})", price, currentPrice, difference);
        }
        return message;
    }

    private static bool isDifference(double threshold, double difference)
    {
        if (Math.Abs(difference) > threshold)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double price, double currentPrice)
    {
        double result = (currentPrice - price) / price;
        return result;
    }
}
