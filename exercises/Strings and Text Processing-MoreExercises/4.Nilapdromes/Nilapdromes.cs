using System;


namespace _4.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                if (inputLine == "end") continue;
                string nilapdrome = CreateNilapdrome(inputLine);
                if (nilapdrome != string.Empty)
                {
                    Console.WriteLine(nilapdrome);
                }
                inputLine = Console.ReadLine();
            }
        }

        public static string CreateNilapdrome(string inputLine)
        {
            string nilapdrome = string.Empty;
            int numberOfChars = 1;
            for (int i = 0; i < inputLine.Length / 2; i++)
            {
                string frontBorder = inputLine.Substring(0, numberOfChars);
                string backBorder = inputLine.Substring(inputLine.Length - numberOfChars, numberOfChars);
                string core = inputLine.Substring(frontBorder.Length, inputLine.Length - backBorder.Length * 2);
                if ((frontBorder == backBorder) && (core != string.Empty))
                {
                    nilapdrome = core + frontBorder + core;
                    return nilapdrome;
                }
                numberOfChars++;
            }
            return nilapdrome;
        }
    }
}
