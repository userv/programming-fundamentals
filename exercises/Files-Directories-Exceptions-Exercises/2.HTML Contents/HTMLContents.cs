using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2.HTML_Contents
{
    public class HTMLContents
    {
        public static void Main()
        {
            Dictionary<string, string> contentDict = new Dictionary<string, string>();
            string inputLine = Console.ReadLine();
            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(' ').ToArray();
                if (inputParams.Length < 2) continue;
                string tag = inputParams[0];
                string content = inputParams[1];
                if (!contentDict.ContainsKey(tag))
                {
                    contentDict.Add(tag, content);
                }
                contentDict[tag] = content;
                inputLine = Console.ReadLine();
            }
            GenerateHtmlFile(contentDict);
        }

        public static void GenerateHtmlFile(Dictionary<string, string> contentDict)
        {
            string fileName = "index.html";
            List<string> contentList=new List<string>();
            contentList.Add($"<!DOCTYPE html>");
            contentList.Add($"<html>");
            contentList.Add($"<head>");
            contentList.Add($"\t<title>{contentDict["title"]}</title>");
            contentList.Add($"</head>");
            contentList.Add($"<body>");
            foreach (var line in contentDict)
            {
                if (line.Key!="title")
                {
                    contentList.Add($"\t<{line.Key}>{line.Value}</{line.Key}>");
                }
                
            }
            contentList.Add($"</body>");
            contentList.Add($"</html>");
            File.WriteAllLines(fileName,contentList);
        }
    }
}
