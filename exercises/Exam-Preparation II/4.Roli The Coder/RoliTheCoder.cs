using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Roli_The_Coder
{
    public class RoliTheCoder
    {
        public class Event
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public SortedSet<string> Participants = new SortedSet<string>();
        }
        public static void Main()
        {

            Dictionary<int, Event> events = new Dictionary<int, Event>();
          //  List<Event> eventsList = new List<Event>();
            string inputLine = Console.ReadLine();
            while (inputLine != "Time for Code")
            {
                if (inputLine == "Time for Code")
                {
                    continue;
                }
                string[] tokens = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int eventID = int.Parse(tokens[0]);
                string eventName = tokens[1];
                if (tokens.Length<2)
                {
                    continue;
                }
                string[] participants = tokens.Skip(2).ToArray();
                if (!participants.All(p => p.StartsWith("@")))
                {
                    continue;
                }
                participants = participants.Select(x => x.Trim('@')).ToArray();
                
                if (eventName[0] != '#')
                {
                    continue;
                }
                eventName = eventName.Trim('#');
                SortedSet<string> newParticipants = new SortedSet<string>();
                foreach (var participant in participants)
                {
                    newParticipants.Add(participant);
                }
                if (!events.ContainsKey(eventID))
                {

                    Event newEvent = new Event
                    {
                        ID = eventID,
                        Name = eventName,
                        Participants = newParticipants
                    };
                    events[eventID] = newEvent;
                }
                if (events[eventID].Name.Contains(eventName))
                {
                    events[eventID].Participants = newParticipants;
                }

                inputLine = Console.ReadLine();
            }
            var orderedEvents = events.Values.OrderByDescending(x => x.Participants.Count);
            foreach (var ev in orderedEvents)
            {
                Console.WriteLine($"{ev.Name} - {ev.Participants.Count}");
                foreach (var paticipant in ev.Participants)
                {
                    Console.WriteLine($"@{paticipant}");
                }
            }
        }
    }
}
