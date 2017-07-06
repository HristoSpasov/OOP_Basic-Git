using _05.Mordor_s_Cruelty_Plan.Animals;
using _05.Mordor_s_Cruelty_Plan.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
    internal class Program
    {
        private static List<Animal> animals;

        private static StringBuilder output;

        static Program()
        {
            animals = new List<Animal>();
            output = new StringBuilder();
        }

        private static void Main()
        {
            ReadAnimals();
            GetOutput();

            Console.WriteLine(output.ToString().Trim()); // Print result
        }

        private static void GetOutput()
        {
            foreach (var animal in animals)
            {
                output.AppendLine(animal.GetType().Name);
                output.Append(animal.ToString());
            }
        }

        private static void ReadAnimals()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Beast!")
                {
                    break;
                }

                string[] animalTokens = Console.ReadLine().Split();

                try
                {
                    switch (line)
                    {
                        case "Dog":
                            animals.Add(new Dog(animalTokens[0], animalTokens[1], animalTokens[2]));
                            break;

                        case "Cat":
                            animals.Add(new Cat(animalTokens[0], animalTokens[1], animalTokens[2]));
                            break;

                        case "Frog":
                            animals.Add(new Frog(animalTokens[0], animalTokens[1], animalTokens[2]));
                            break;

                        case "Kitten":
                            animals.Add(new Kitten(animalTokens[0], animalTokens[1]));
                            break;

                        case "Tomcat":
                            animals.Add(new Tomcat(animalTokens[0], animalTokens[1]));
                            break;

                        default:
                            throw new InvalidInput();
                    }
                }
                catch (InvalidInput e)
                {
                    output.AppendLine(e.Message);
                }
            }
        }
    }
}