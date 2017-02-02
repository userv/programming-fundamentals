using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher_Roulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string direction ="end"; 
            string lastString= string.Empty;
            string cypherString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString==lastString)
                {
                    cypherString = string.Empty;
                    continue;
                }
                lastString = currentString;
                if (currentString == "spin")
                {
                    if (direction=="end")
                    {
                        direction = "front";
                    }
                    else
                    {
                        direction = "end";
                    }
                    i--;
                    continue;
                }
                switch (direction)
                {
                    case "front":
                        cypherString = currentString + cypherString;
                        break;
                    case "end":
                        cypherString += currentString;
                        break;
                }
            }
            Console.WriteLine(cypherString);
        }
    }
}
