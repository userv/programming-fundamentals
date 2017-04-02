using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords =
                Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var word in banWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
