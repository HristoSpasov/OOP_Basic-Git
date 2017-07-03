namespace _04.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static List<Person> personList = new List<Person>();

        private static void Main()
        {
            ReadAllPeople(); // Read all people and add to list

            // Print all people above the age of 30
            personList.Where(a => a.Age > 30)
                .OrderBy(n => n.Name)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }

        private static void ReadAllPeople()
        {
            int totalPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalPeople; i++)
            {
                string[] lineTokens = Console.ReadLine().Split();

                personList.Add(new Person(lineTokens[0], int.Parse(lineTokens[1])));
            }
        }
    }
}