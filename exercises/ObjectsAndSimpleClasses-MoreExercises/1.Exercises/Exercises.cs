using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exercises
{
    public class Exercises
    {
        public class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems = new List<string>();

            public void PrintExercise()
            {
                Console.WriteLine($"Exercises: {Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {JudgeContestLink}");
                int count = 1;
                foreach (var problem in Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }

        public static Exercise ReadExercise()
        {
            Exercise exercise = new Exercise();
            string[] inputLine = Console.ReadLine()
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            exercise.Topic = inputLine[0].Trim();
            exercise.CourseName = inputLine[1].Trim();
            exercise.JudgeContestLink = inputLine[2].Trim();
            string[] problems =
                inputLine[3].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var problem in problems)
            {
                exercise.Problems.Add(problem);

            }
            return exercise;
        }
        public static Exercise AddExercise(string input)
        {
            Exercise exercise = new Exercise();
            string[] inputLine = input
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            exercise.Topic = inputLine[0].Trim();
            exercise.CourseName = inputLine[1].Trim();
            exercise.JudgeContestLink = inputLine[2].Trim();
            string[] problems =
                inputLine[3].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var problem in problems)
            {
                exercise.Problems.Add(problem);
            }
            return exercise;
        }
        public static void Main()
        {
            List<Exercise> exercises = new List<Exercise>();
            string inputLine = Console.ReadLine();
            while (inputLine != "go go go")
            {
                Exercise exercise = AddExercise(inputLine);
                exercises.Add(exercise);
                inputLine = Console.ReadLine();
            }
            foreach (var exercise in exercises)
            {
                exercise.PrintExercise();
            }
        }
    }
}
