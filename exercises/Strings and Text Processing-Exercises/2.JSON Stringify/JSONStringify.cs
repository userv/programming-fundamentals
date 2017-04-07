using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _2.JSON_Stringify
{
    public class JSONStringify
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int[] Grades { get; set; }

        }
        public static void Main(string[] args)
        {
            List<Student> students=new List<Student>();
            string inputLine = Console.ReadLine();
            while (inputLine!= "stringify")
            {
                string[] tokens = inputLine.Split(new char[] {' ', ':', '-', '>', ','},
                    StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 1)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    int[] grades = tokens.Skip(2).Select(int.Parse).ToArray();
                    Student newStudent=new Student
                    {
                        Name = name,
                        Age = age,
                        Grades = grades
                    };
                    students.Add(newStudent);
                }
                inputLine = Console.ReadLine();
            }
            //Console.Write("[");
            //for (int i = 0; i < students.Count; i++)
            //{
            //    string formatedString = string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}}",
            //        students[i].Name,students[i].Age,string.Join(", ",students[i].Grades));
            //    Console.Write(formatedString);
            //    if (i != students.Count-1)
            //    {
            //        Console.Write(",");
            //    }
            //}
            //Console.Write("]");

            Console.WriteLine(
                "[" +
                string.Join(",",students.Select(x =>
                $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ",x.Grades)}]}}"))
                 +"]");
        }
    }
}
