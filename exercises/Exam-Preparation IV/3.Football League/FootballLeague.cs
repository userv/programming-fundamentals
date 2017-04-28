using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _3.Football_League
{
    public class ScoreInfo
    {
        public int Goals { get; set; }
        public int Points { get; set; }
    }
    public class FootballLeague
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());
            string pattern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]+)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$";
            var leagueStandings = new Dictionary<string, ScoreInfo>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "final") break;
                Match match = Regex.Match(inputLine, pattern);
                if (match.Success)
                {
                    string team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                    string team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                    int team1Score = int.Parse(match.Groups["team1Score"].Value);
                    int team2Score = int.Parse(match.Groups["team2Score"].Value);
                    if (!leagueStandings.ContainsKey(team1Name))
                    {
                        leagueStandings[team1Name]=new ScoreInfo();
                    }
                    if (!leagueStandings.ContainsKey(team2Name))
                    {
                        leagueStandings[team2Name] = new ScoreInfo();
                    }
                    if (team1Score>team2Score)
                    {
                        leagueStandings[team1Name].Points += 3;
                    }
                    else if (team1Score==team2Score)
                    {
                        leagueStandings[team1Name].Points ++;
                        leagueStandings[team2Name].Points ++;
                    }
                    else
                    {
                        leagueStandings[team2Name].Points += 3;
                    }
                    leagueStandings[team1Name].Goals+=team1Score;
                    leagueStandings[team2Name].Goals += team2Score;
                }
            }
            var sortedStandings = leagueStandings.OrderByDescending(t => t.Value.Points).ThenBy(t => t.Key);
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var team in sortedStandings)
            {
                string teamName = team.Key;
                int points = team.Value.Points;
                Console.WriteLine($"{place++}. {teamName} {points}");
            }
            var topScoredGoals = leagueStandings.OrderByDescending(t => t.Value.Goals).ThenBy(t => t.Key).Take(3);
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in topScoredGoals)
            {
                string teamName = team.Key;
                int goals = team.Value.Goals;
                Console.WriteLine($"- {teamName} -> {goals}");
            }
            
        }
    }
}
