using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.JSON_Parse
{
    public class JSONParse
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int[] Grades { get; set; }

        }
        public static void Main()
        {
            List<Student> students = new List<Student>();
            string inputLine = Console.ReadLine().Trim(new char[] { ']' });

            string[] tokens = inputLine.Split(new char[] { '}' },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i] = RemoveCharsFromString(tokens[i], new char[] { '[', '{', ']', '\"', ',' });
                string[] studentParams = tokens[i].Split(new char[] { ' ', ':' },
                     StringSplitOptions.RemoveEmptyEntries);
                string name = studentParams[1];
                int age = int.Parse(studentParams[3]);
                int[] grades = studentParams.Skip(5).Select(int.Parse).ToArray();
                Student newStudent = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };
                students.Add(newStudent);
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Name} : {student.Age} -> ");
                if (student.Grades.Length > 0)
                {
                    Console.WriteLine($"{string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }

        public static string RemoveCharsFromString(string str, char[] chars)
        {
            foreach (var ch in chars)
            {
                str = str.Replace(ch.ToString(), " ");
            }
            return str;
        }
    }
}
