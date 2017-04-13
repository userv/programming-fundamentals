using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Commits
{
    public class Commits
    {
        class Commit
        {
            public string Repo { get; set; }
            public string CommitHash { get; set; }
            public string Message { get; set; }
            public int Additions { get; set; }
            public int Deletions { get; set; }
        }
        public static void Main()
        {
            Dictionary<string, List<Commit>> usersCommits = new Dictionary<string, List<Commit>>();
            string urlPattern = @"(https:\/\/github.com)\/([A-z0-9-]+)\/([a-z-_]+)\/commit\/([a-f0-9{20}]+)\,(.+?),(\d{1,20}),(\d{1,20})";

            //Group 1.    104 - 122 `https://github.com`
            //Group 2.    123 - 133 `pesho - 1232`            \\user
            //Group 3.    134 - 144 `db - checker`            \\ repo
            //Group 4.    152 - 192 `5ca49ccc157c98af2c71391223e4b254ee327134`  \\hash
            //Group 5.    193 - 213 `fix SELECT statement`     \\ message
            //Group 6.    214 - 215 `9`                        \\ additions
            //Group 7.    216 - 218 `19`                       \\ deletions

            string inputLine = Console.ReadLine();
            Regex regex = new Regex(urlPattern);
            while (inputLine != "git push")
            {
                if (inputLine == "git push") continue;
                MatchCollection matches = regex.Matches(inputLine);
                foreach (Match commit in matches)
                {
                    string user = commit.Groups[2].Value;
                    string repo = commit.Groups[3].Value;
                    string hash = commit.Groups[4].Value;
                    string message = commit.Groups[5].Value;
                    int additions = int.Parse(commit.Groups[6].Value);
                    int deletions = int.Parse(commit.Groups[7].Value);
                    Commit newCommit = new Commit
                    {
                        Repo = repo,
                        CommitHash = hash,
                        Message = message,
                        Additions = additions,
                        Deletions = deletions
                    };
                    if (!usersCommits.ContainsKey(user))
                    {
                        usersCommits.Add(user, new List<Commit>());
                    }
                    usersCommits[user].Add(newCommit);
                }
                inputLine = Console.ReadLine();
            }
            foreach (var users in usersCommits.OrderBy(x => x.Key))
            {
                int totalAdditionsCount = 0;
                int totalDeletionsCount = 0;
                Console.WriteLine($"{users.Key}:");
                Console.WriteLine($"  {users.Value[0].Repo}:");
                foreach (var commit in users.Value)
                {
                    Console.WriteLine($"    commit {commit.CommitHash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    totalAdditionsCount += commit.Additions;
                    totalDeletionsCount += commit.Deletions;
                }
                Console.WriteLine($"Total: {totalAdditionsCount} additions, {totalDeletionsCount} deletions");
            }
        }
    }
}
