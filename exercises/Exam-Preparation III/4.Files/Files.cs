using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            //      ROOTFOLDER,         FileName, Size
            Dictionary<string, Dictionary<string, long>> rootFolder = new Dictionary<string, Dictionary<string, long>>();
            //        FileName,Extension
            Dictionary<string, string> fileWithExtension = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split('\\');
                string root = inputLine[0];
                string[] fileParams = inputLine.Last().Split(';');
                string filename = fileParams[0].Trim();
                string fileExtension = filename.Split('.').Last();
                long fileSize = long.Parse(fileParams[1]);
                if (!rootFolder.ContainsKey(root))
                {
                    rootFolder[root] = new Dictionary<string, long>();
                }
                if (!fileWithExtension.ContainsKey(filename))
                {
                    fileWithExtension.Add(filename, fileExtension);
                }
                fileWithExtension[filename] = fileExtension;
                rootFolder[root][filename] = fileSize;
            }
            string[] inputQuery =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string queryRoot = inputQuery[2];
            string queryExtension = inputQuery[0];
            Dictionary<string, long> extractedFiles = new Dictionary<string, long>();
            if (rootFolder.ContainsKey(queryRoot))
            {
                foreach (var file in rootFolder[queryRoot]) 
                {
                    if (fileWithExtension[file.Key] == queryExtension)
                    {
                        extractedFiles.Add(file.Key, file.Value);
                    }
                }
            }
            if (extractedFiles.Count > 0)
            {
                foreach (var file in extractedFiles.OrderByDescending(s => s.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
