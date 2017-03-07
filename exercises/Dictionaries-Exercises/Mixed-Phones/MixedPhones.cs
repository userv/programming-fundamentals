using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed_Phones
{
   public  class MixedPhones
    {
        public static void Main()
        {
            SortedDictionary<string,decimal> phoneBook=new SortedDictionary<string, decimal>();
            string inputLine = string.Empty;
            while (inputLine!="Over")
            {
                inputLine = Console.ReadLine();
                if (inputLine=="Over")continue;
                string[] elements = inputLine.Split(':').ToArray();
                elements[0] = elements[0].Trim();
                elements[1] = elements[1].Trim();
                string personName=string.Empty;
                decimal phoneNumber=0;
                bool parsed = decimal.TryParse(elements[0],out phoneNumber );
                if (parsed)
                {
                    personName = elements[1];
                    phoneBook.Add(personName,phoneNumber);
                }
                else
                {
                    parsed= decimal.TryParse(elements[1], out phoneNumber);
                    if (parsed)
                    {
                        personName = elements[0];
                        phoneBook.Add(personName, phoneNumber);
                    }
                }
            }
            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                
            }

        }
    }
}
