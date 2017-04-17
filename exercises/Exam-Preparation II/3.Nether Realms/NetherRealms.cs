using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Nether_Realms
{
    public class NetherRealms
    {
        class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }
        }
        public static void Main()
        {
            SortedList<string, Demon> demons = new SortedList<string, Demon>();
            string[] demonStrings =
                Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string healthPattern = @"([^0-9-.+,])([ -~]??)";
        //    string damagePattern = @"([0-9-.+]+)";
            string damagePattern = @"-?\d+\.?\d*";
            //string healthPattern = @"([^0-9-.+,*/])([ -~]??)";
            //string damagePattern = @"([0-9-.+*\/]+)";
            Regex regexHealth = new Regex(healthPattern);
            Regex regexDamage = new Regex(damagePattern);
            foreach (var demon in demonStrings)
            {
                MatchCollection healthCollection = regexHealth.Matches(demon);
                MatchCollection damageCollection = regexDamage.Matches(demon);
                int totalHealth = 0;
                double damage = 1.0;
                double totalDamage = 0;
                for (int i = 0; i < healthCollection.Count; i++)
                {
                    if (healthCollection[i].Value == "/")
                    {
                        damage /= 2;
                        continue;
                    }
                    else if (healthCollection[i].Value == "*")
                    {
                        damage *= 2;
                        continue;
                    }
                    totalHealth += healthCollection[i].Value[0];
                }
                for (int i = 0; i < damageCollection.Count; i++)
                {

                    double damagePoints = 0;

                    if (double.TryParse(damageCollection[i].Value, out damagePoints))
                    {
                        totalDamage += damagePoints;
                    }
                }
                totalDamage *= damage;
                Demon newDemon = new Demon
                {
                    Name = demon,
                    Health = totalHealth,
                    Damage = totalDamage
                };
                demons.Add(newDemon.Name, newDemon);

            }
            foreach (var demon in demons.Values)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}
