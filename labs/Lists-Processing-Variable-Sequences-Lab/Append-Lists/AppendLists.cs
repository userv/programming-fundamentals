using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < lists.Count; i++)
            {
                lists[i] = lists[i].Trim();
                result.Add(lists[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            }
            result.Reverse();
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(string.Join(" ", result[i]) + " ");
            }

        }
    }
}
