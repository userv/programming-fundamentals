using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logins
{
    public class UserLogins
    {
        public static void Main()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            string inputLine = Console.ReadLine();
            int unsuccessufulLogin = 0;
            while (inputLine != "login")
            {
                string[] tokens = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = tokens[0].Trim();
                string password = tokens[1].Trim();
                if (!users.ContainsKey(username))
                {
                    users.Add(username, password);
                }
                else
                {
                    users[username] = password;
                }
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = tokens[0].Trim();
                string password = tokens[1].Trim();
                if (!users.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessufulLogin++;
                }
                else
                {
                    if (users[username] == password)
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        unsuccessufulLogin++;
                    }
                    
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessufulLogin}");
        }
    }
}
