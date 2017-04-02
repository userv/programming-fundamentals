using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace _3.User_Database
{
    public class UserDatabase
    {
        private static string usersDbFile = "users.txt";
        private static Dictionary<string, string> usersDb = new Dictionary<string, string>();
        private static bool loggedUser = false;
        public static void Main()
        {
            if (File.Exists(usersDbFile))
            {
                ReadUsersDb();
            }
            else
            {
                File.Create(usersDbFile).Close();
            }

            string inputLine = Console.ReadLine();
            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(' ');
                string command = inputParams[0];
                switch (command)
                {
                    case "register":
                        if (inputParams.Length == 4)
                        {
                            string username = inputParams[1];
                            string password = inputParams[2];
                            string confirmPassword = inputParams[3];
                            Register(username, password, confirmPassword);
                        }
                        break;
                    case "login":
                        if (inputParams.Length == 3)
                        {
                            string username = inputParams[1];
                            string password = inputParams[2];
                            Login(username, password);
                        }

                        break;
                    case "logout":
                        Logout();
                        break;
                }

                inputLine = Console.ReadLine();
            }
        }

        public static void Logout()
        {
            loggedUser = false;
        }

        public static void Login(string username, string password)
        {
            if (loggedUser)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }
            if (!usersDb.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }
            if (usersDb[username] != password)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }
            loggedUser = true;
        }

        public static void Register(string username, string password, string confirmPassword)
        {
            if (usersDb.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }
            if (password != confirmPassword)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }
            usersDb[username] = password;
            File.AppendAllText(usersDbFile, $"{username} {password}{Environment.NewLine}");

        }

        public static void ReadUsersDb()
        {
            string[] users = File.ReadAllLines(usersDbFile);
            foreach (var user in users)
            {
                string[] userData = user.Split(' ');
                string username = userData[0];
                string password = userData[1];
                usersDb[username] = password;
            }
        }
    }
}
