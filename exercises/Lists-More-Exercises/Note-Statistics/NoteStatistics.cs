using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Statistics
{
    public class NoteStatistics
    {
        public static double naturalsSum = 0;
        public static double sharpsSum = 0;
        public static void Main()
        {
            List<string> noteList = new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<double> frequencies = new List<double>() { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            PrintNotes(input,noteList,frequencies);
            PrintNaturals(input,noteList,frequencies);
            PrintSharps(input,noteList,frequencies);
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }

        public static void PrintSharps(List<double> input, List<string> noteList, List<double> frequencies)
        {
            List<string> sharps = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string note = noteList[frequencies.IndexOf(input[i])];

                if (note.Length > 1)
                {
                    sharps.Add(note);
                    sharpsSum += frequencies[noteList.IndexOf(note)];
                  
                }
            }
            Console.WriteLine("Sharps: "+string.Join(", ", sharps));
        }

        public static void PrintNaturals(List<double> input, List<string> noteList, List<double> frequencies)
        {
            List<string> naturals = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string note = noteList[frequencies.IndexOf(input[i])];
               
                if (note.Length<2)
                {
                    naturals.Add(note);
                    naturalsSum += frequencies[noteList.IndexOf(note)];
                }
            }
            Console.WriteLine("Naturals: "+string.Join(", ", naturals));
           
        }

        private static void PrintNotes(List<double> input, List<string> noteList, List<double> frequencies)
        {
            Console.Write("Notes: ");
            for (int i = 0; i < input.Count; i++)
            {
                
                Console.Write(noteList[frequencies.IndexOf(input[i])]+" ");
            }
            Console.WriteLine();
        }

    }
}
