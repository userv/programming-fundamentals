using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SoftUni_Karaoke
{
    public class Karaoke
    {
        public static void Main()
        {
            Dictionary<string, SortedSet<string>> awards = new Dictionary<string, SortedSet<string>>();
            List<string> participantsList = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songsList = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            string inputLine = Console.ReadLine();
            while (inputLine != "dawn")
            {
                if (inputLine == "dawn") continue;
                string[] inputData = inputLine.Split(',').Select(x => x.Trim()).ToArray();
                string participant = inputData[0];
                string song = inputData[1];
                string award = inputData[2];
                if (participantsList.Contains(participant) && songsList.Contains(song))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards.Add(participant, new SortedSet<string>());
                    }
                    awards[participant].Add(award);
                }
                inputLine = Console.ReadLine();
            }
            if (awards.Count > 0)
            {
                var sortedParticipantAwards = awards
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x =>x.Key, x =>x.Value);
                foreach (var participant in sortedParticipantAwards)
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }

        }
    }
}
