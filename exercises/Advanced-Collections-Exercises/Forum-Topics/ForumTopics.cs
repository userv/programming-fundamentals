using System;
using System.Collections.Generic;
using System.Linq;


namespace Forum_Topics
{
    public class ForumTopics
    {
        public static void Main()
        {
            Dictionary<string, HashSet<string>> forum = new Dictionary<string, HashSet<string>>();
            string inputLine = string.Empty;
            while (inputLine != "filter")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "filter") continue;
                string[] tokens = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0].Trim();
                var tags = tokens[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                AddTopic(forum, topic, tags);
            }
            string[] filterTags = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            PrintTopics(forum, filterTags);
        }

        public static void PrintTopics(Dictionary<string, HashSet<string>> forum, string[] filterTags)
        {
            foreach (var topic in forum)
            {
                bool containAllTags = true;
                foreach (var tag in filterTags)
                {
                    if (!topic.Value.Contains(tag))
                    {
                        containAllTags = false;
                        break;
                    }
                }
                if (containAllTags)
                {
                    List<string> strList = new List<string>();
                    foreach (var str in topic.Value)
                    {
                        strList.Add($"#{str}");
                    }
                    Console.WriteLine($"{topic.Key} | {string.Join(", ", strList)}");
                }
            }

        }

        public static void AddTopic(Dictionary<string, HashSet<string>> forum, string topic, List<string> tags)
        {
            if (!forum.ContainsKey(topic))
            {
                forum[topic] = new HashSet<string>();
                HashSet<string> tagSet = new HashSet<string>(tags);
                forum[topic] = tagSet;
            }
            else
            {
                var exsitingTags = forum[topic];
                tags.InsertRange(0, exsitingTags);
                HashSet<string> tagSet = new HashSet<string>(tags);
                forum[topic] = tagSet;
            }

        }
    }
}
