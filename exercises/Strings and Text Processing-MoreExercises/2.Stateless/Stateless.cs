using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stateless
{
    public class Stateless
    {
        public static void Main()
        {

            string inputLine = Console.ReadLine();
            string fiction = string.Empty;
            string states = string.Empty;
            while (inputLine != "collapse")
            {
                states = inputLine;
                fiction = Console.ReadLine();
                Collapse(states, fiction);
                inputLine = Console.ReadLine();
            }
        }

        public static void Collapse(string states, string fiction)
        {
            bool end = false;
            while (!end)
            {
                states = states.Replace(fiction, "");
                fiction = fiction.Remove(0, 1);
                try
                {
                    fiction = fiction.Remove(fiction.Length - 1, 1);
                }
                catch (Exception e)
                {
                    end = true;
                }
                if (fiction.Length < 1)
                {
                    end = true;
                }
            }
            if (states.Length < 1)
            {
                Console.WriteLine("(void)");
            }
            else
            {
                Console.WriteLine(states.Trim());
            }
        }
    }
}
