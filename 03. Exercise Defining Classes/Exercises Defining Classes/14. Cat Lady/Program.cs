namespace _14.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static readonly HashSet<Cat> Cats;

        static Program()
        {
            // Static ctor
            Cats = new HashSet<Cat>();
        }

        private static void Main()
        {
            ReadAllCats();

            string catToPrint = Console.ReadLine();

            var cat = Cats.FirstOrDefault(cn => cn.Name == catToPrint);

            Console.WriteLine($"{cat.ToString()}");
        }

        private static void ReadAllCats()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] lineTokens = line.Split();

                switch (lineTokens[0])
                {
                    case "Siamese":
                        ProcessSiamese(lineTokens);
                        break;

                    case "Cymric":
                        ProcessCymric(lineTokens);
                        break;

                    case "StreetExtraordinaire":
                        ProcessStreetExtraordinaire(lineTokens);
                        break;
                }
            }
        }

        private static void ProcessStreetExtraordinaire(string[] lineTokens)
        {
            string breed = lineTokens[0];
            string name = lineTokens[1];
            int meowDecibels = int.Parse(lineTokens[2]);

            StreetExtraordinaire newStreetExtraordinaire = new StreetExtraordinaire(name, breed, meowDecibels);

            Cats.Add(newStreetExtraordinaire); // Add to cat set
        }

        private static void ProcessCymric(string[] lineTokens)
        {
            string breed = lineTokens[0];
            string name = lineTokens[1];
            double furLength = double.Parse(lineTokens[2]);

            Cymric newCymric = new Cymric(name, breed, furLength);

            Cats.Add(newCymric); // Add to cat set
        }

        private static void ProcessSiamese(string[] lineTokens)
        {
            string breed = lineTokens[0];
            string name = lineTokens[1];
            int earSize = int.Parse(lineTokens[2]);

            Siamese newSiamese = new Siamese(name, breed, earSize);

            Cats.Add(newSiamese); // Add to cat set
        }
    }
}