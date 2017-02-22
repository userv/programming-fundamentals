using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_Downloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            List<string> blacklistedWords = Console.ReadLine().Split(' ').ToList();
            List<string> tracksList=new List<string>();
            string input = string.Empty;
            while (input!="end")
            {
                input = Console.ReadLine();
                bool removeTrack = false;
                if (input!="end")
                {
                    for (int i = 0; i < blacklistedWords.Count; i++)
                    {
                        if (input.Contains(blacklistedWords[i]))
                        {
                            removeTrack = true;
                        }
                    }
                    if (!removeTrack)
                    {
                        tracksList.Add(input);
                        
                    }
                }
            }
            tracksList.Sort();
            for (int i = 0; i < tracksList.Count; i++)
            {
                Console.WriteLine(tracksList[i]);
            }
        }
    }
}
