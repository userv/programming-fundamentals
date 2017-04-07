using System;


namespace _1.Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            while (input!="end")
            {
                string[] inputLine = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length==1) continue;
                string formatedString = inputLine[0].Trim();
                string[] elements = inputLine[1].Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < elements.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";
                    formatedString = formatedString.Replace(currentPlaceholder, elements[i]);
                }
                Console.WriteLine(formatedString);
              //  Console.WriteLine(formatedString, elements);
                input = Console.ReadLine();
            }

        }
    }
}
