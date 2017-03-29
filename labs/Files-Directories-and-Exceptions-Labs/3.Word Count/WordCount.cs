using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            string[] wordsFile = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
                .Split(new char[]{'\n','\r',' ','.',',','?','!','-'},StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,int> counter=new Dictionary<string, int>();

            foreach (var word in wordsFile)
            {
                int count = 0;
                foreach (var line in text)
                {
                  if (line.Equals(word)) count++;
                }
                counter.Add(word,count);
            }
            foreach (var kvp in counter.OrderByDescending(k => k.Value))
            {
                File.AppendAllText("output.txt", $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
             //   Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
