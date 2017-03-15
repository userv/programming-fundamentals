using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace _1.Registered_Users
{
    public class RegisteredUsers
    {
        public static void Main()
        {
            Dictionary<string,DateTime> registredUsers=new Dictionary<string, DateTime>();
            string inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                string[] tokens =
                    inputLine.Split(new char[] {' ','-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                DateTime dt = DateTime.ParseExact(tokens[1], "dd/MM/yyyy",CultureInfo.InvariantCulture);
                registredUsers[tokens[0]] = dt;
                inputLine = Console.ReadLine();
            }
            var sorted = registredUsers
                .Reverse()
                .OrderBy(k => k.Value)
                .Take(5)
                .OrderByDescending(k=>k.Value)
                .ToArray();
            foreach (var user in sorted)
            {
                Console.WriteLine($"{user.Key}");
                
            }
        }
    }
}
