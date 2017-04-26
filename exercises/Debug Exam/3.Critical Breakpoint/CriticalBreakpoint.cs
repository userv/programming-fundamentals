using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _3.Critical_Breakpoint
{
    public class Line
    {
        public BigInteger X1 { get; set; }
        public BigInteger Y1 { get; set; }
        public BigInteger X2 { get; set; }
        public BigInteger Y2 { get; set; }
        public BigInteger CriticalRatio { get; set; }
    }
    public class CriticalBreakpoint
    {
        public static void Main(string[] args)
        {
            List<Line> lines = new List<Line>();
            string inputLine = Console.ReadLine();
            while (inputLine != "Break it.")
            {
                long[] inputParams = inputLine.Split().Select(long.Parse).ToArray();
                Line line = new Line
                {
                    X1 = inputParams[0],
                    Y1 = inputParams[1],
                    X2 = inputParams[2],
                    Y2 = inputParams[3],
                    CriticalRatio = BigInteger.Abs((inputParams[2] + inputParams[3]) - (inputParams[0] + inputParams[1]))
                };
                lines.Add(line);
                inputLine = Console.ReadLine();
            }
            BigInteger actualRatio = 0;
            bool hasBreakpoint = true;
            foreach (Line line in lines)
            {
                if (actualRatio == 0 && line.CriticalRatio != 0)
                {
                    actualRatio = line.CriticalRatio;
                }
                if ((line.CriticalRatio != actualRatio) && (line.CriticalRatio != 0))
                {
                    hasBreakpoint = false;
                    break;
                }


            }
            if (hasBreakpoint)
            {
                BigInteger criticalBreakpoint = BigInteger.Pow(actualRatio, lines.Count) % lines.Count;
                foreach (Line line in lines)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }
                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
