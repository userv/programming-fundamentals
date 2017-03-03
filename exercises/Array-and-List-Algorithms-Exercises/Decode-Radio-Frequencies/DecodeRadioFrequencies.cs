using System;
using System.Collections.Generic;
using System.Linq;

namespace Decode_Radio_Frequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            string[] radioFrequencies = Console.ReadLine().Split(' ').ToArray();
            List<string> decodedFreq = new List<string>();
            DecodeFrequencies(radioFrequencies, decodedFreq);
            Console.WriteLine(string.Join("", decodedFreq));
        }

        public static void DecodeFrequencies(string[] radioFrequencies, List<string> decodedFreq)
        {
            for (int i = 0; i < radioFrequencies.Length; i++)
            {
                double[] freq = radioFrequencies[i].Split('.').Select(double.Parse).ToArray();
                if (freq[0] > 0)
                {
                    string leftPart = ((char) freq[0]).ToString();
                    decodedFreq.Insert(i, leftPart);
                }
                if (freq[1] > 0)
                {
                    string rightPart = ((char) freq[1]).ToString();
                    decodedFreq.Insert(decodedFreq.Count - i, rightPart);
                }
            }
        }
    }
}
