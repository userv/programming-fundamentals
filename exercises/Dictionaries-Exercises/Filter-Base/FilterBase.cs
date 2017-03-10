using System;
using System.Collections.Generic;
using System.Linq;


namespace Filter_Base
{
    public class FilterBase
    {
        public static void Main()
        {
            Dictionary<string, int> employeeAge = new Dictionary<string, int>();
            Dictionary<string, double> employeeSalary = new Dictionary<string, double>();
            Dictionary<string, string> employeePostion = new Dictionary<string, string>();
            string inputLine = Console.ReadLine();
            while (inputLine != "filter base")
            {
                string[] tokens = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0].Trim();
                string data = tokens[1].Trim();
                int age;
                double salary;
                bool parsedDouble = double.TryParse(data, out salary);
                bool parsedInt= int.TryParse(data, out age);
                if (parsedInt && parsedDouble)
                {
                    employeeAge.Add(name,age);
                }

                else if (parsedDouble && !parsedInt)
                {
                    employeeSalary.Add(name,salary);
                }
                if (!parsedInt && !parsedDouble)
                {
                    employeePostion.Add(name,data);
                }
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine().ToLower();
            switch (inputLine)
            {
                case "age":
                    foreach (var kvp in employeeAge)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Age: {kvp.Value}");
                        Console.WriteLine(new string('=',20));
                    }
                    break;
                case "position":
                    foreach (var kvp in employeePostion)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "salary":
                    foreach (var kvp in employeeSalary)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Salary: {kvp.Value:F2}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }


        }


    }
}

