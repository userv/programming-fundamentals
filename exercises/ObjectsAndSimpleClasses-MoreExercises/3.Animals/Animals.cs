using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public class Animals
    {
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }

            public void ProduceSound()
            {
                Console.WriteLine($"I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }
        public class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IntelginceQuotient { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine($"I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }
        public class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine($"I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }

        public static void Main()
        {
            Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakes=new Dictionary<string, Snake>();
            string inputLine = Console.ReadLine();
            while (inputLine!= "I'm your Huckleberry")
            {
                string[] tokens = inputLine.Split(' ').ToArray();
                if (tokens.Length>2)
                {
                    string type = tokens[0];
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int specialAbility = int.Parse(tokens[3]);
                    switch (type)
                    {
                        case "Dog":
                            Dog newDog=new Dog
                            {
                                Name = name,
                                Age = age,
                                NumberOfLegs = specialAbility
                            };
                            dogs.Add(newDog.Name,newDog);
                            break;
                        case "Cat":
                            Cat newCat = new Cat
                            {
                                Name = name,
                                Age = age,
                                IntelginceQuotient = specialAbility
                            };
                            cats.Add(newCat.Name, newCat);
                            break;
                        case "Snake":
                            Snake newSnake = new Snake
                            {
                                Name = name,
                                Age = age,
                                CrueltyCoefficient = specialAbility
                            };
                            snakes.Add(newSnake.Name, newSnake);
                            break;
                    }
                }
                else
                {
                    string name = tokens[1];
                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else if (snakes.ContainsKey(name))
                    {
                        snakes[name].ProduceSound();
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelginceQuotient}");
            }
            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
