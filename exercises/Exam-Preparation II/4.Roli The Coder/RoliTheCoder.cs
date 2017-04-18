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
            public List<string> Participants = new List<string>();
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
                
                int eventID =0;
                if (!int.TryParse(tokens[0], out eventID))
                {
                    continue;
                }
                string eventName = tokens[1];
                if (tokens.Length<2)
                {
                    continue;
                }
                List<string> participants = tokens.Skip(2).ToList();
                if (!participants.All(p => p.StartsWith("@")))
                {
                    continue;
                }
                participants = participants.Select(x => x.Trim('@')).ToList();
                
                if (eventName[0] != '#')
                {
                    continue;
                }
                eventName = eventName.Trim('#');
                participants.Sort();
                if (!events.ContainsKey(eventID))
                {

                    Event newEvent = new Event
                    {
                        ID = eventID,
                        Name = eventName,
                        Participants = participants
                    };
                    events[eventID] = newEvent;
                }
                if (events[eventID].Name.Contains(eventName))
                {
                    foreach (var participant in participants)
                    {
                        if (!events[eventID].Participants.Contains(participant))
                        {
                            events[eventID].Participants.Add(participant);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
            var orderedEvents = events.Values.OrderByDescending(x => x.Participants.Count);
            foreach (var ev in orderedEvents)
            {
                Console.WriteLine($"{ev.Name} - {ev.Participants.Count}");
                foreach (var paticipant in ev.Participants.OrderBy(p=>p))
                {
                    Console.WriteLine($"@{paticipant}");
                }
            }
        }
    }
}
