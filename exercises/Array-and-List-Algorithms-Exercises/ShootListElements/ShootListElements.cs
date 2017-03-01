using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
   public class ShootListElements
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            int lastRemoved=0;
            string inputLine =string.Empty;
            while (inputLine!="stop")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "stop")
                {
                    if (numbers.Count==0)
                    {
                        Console.WriteLine($"you shot them all. last one was {lastRemoved}");
                        break;
                    }
                    Console.WriteLine($"survivors: {string.Join(" ",numbers)}");
                    break;
                }
                if (inputLine=="bang")
                {
                    if (numbers.Count>0)
                    {
                        double average = AverageOfElements(numbers);
                        lastRemoved = RemoveSmallerElement(numbers, average);
                        if (lastRemoved != -1)
                        {
                            Console.WriteLine($"shot {lastRemoved}");
                            DecerementAllElements(numbers);
                       }

                    }
                    else
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        break;
                    }
                    

                }
                else
                {
                    numbers.Insert(0, int.Parse(inputLine)); 
                }
                
            }
        }

        public static void DecerementAllElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        public static int RemoveSmallerElement(List<int> numbers, double average)
        {
          
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<=average)
                {
                    int lastRemoved = numbers[i];
                    numbers.RemoveAt(i);
                    return lastRemoved;
                }
            }

            return -1;
        }

        public static double AverageOfElements(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return (double) sum/numbers.Count;
        }
    }
}
