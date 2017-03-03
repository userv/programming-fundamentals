using System;
using System.Collections.Generic;
using System.Linq;


namespace ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main()
        {
            string[] stringsArray = Console.ReadLine().Split(' ').ToArray();
            List<string> wordsList = new List<string>();
            int[] counts;
            counts = CalculateOccurrences(stringsArray, wordsList);
            SortElements(wordsList, counts);
            PrintStatistics(wordsList, counts, stringsArray);
           
        }

        public static void PrintStatistics(List<string> wordsList, int[] counts, string[] stringsArray)
        {
            for (int i = 0; i < wordsList.Count; i++)
            {
                double times = (double) counts[i]/stringsArray.Length*100;
                Console.WriteLine($"{wordsList[i]} -> {counts[i]} times ({times:F2}%)");
            }
        }

        public static int[] CalculateOccurrences(string[] stringsArray, List<string> wordsList)
        {
            for (int i = 0; i < stringsArray.Length; i++)
            {
                if (!wordsList.Contains(stringsArray[i]))
                {
                    wordsList.Add(stringsArray[i]);
                }
            }
            int[] counts = new int[wordsList.Count];

            for (int i = 0; i < wordsList.Count; i++)
            {
                for (int j = 0; j < stringsArray.Length; j++)
                {
                    if (wordsList[i] == stringsArray[j])
                    {
                        counts[i]++;
                    }
                }
            }
            return counts;
        }

        public static void SortElements(List<string> wordsList, int[] counts)
        {
            bool sorted = true;
            do
            {
                sorted = true;
                for (int i = 0; i < counts.Length - 1; i++)
                {
                    string tempString = string.Empty;
                    int tempInt = 0;
                    // int index = string.Compare(strings[i], strings[i + 1]);
                    if (counts[i] < counts[i + 1])
                    {
                        tempInt = counts[i];
                        tempString = wordsList[i];
                        counts[i] = counts[i + 1];
                        counts[i + 1] = tempInt;
                        wordsList[i] = wordsList[i + 1];
                        wordsList[i + 1] = tempString;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }
    }
}
