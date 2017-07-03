namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static readonly List<Trainer> Trainers;

        static Program()
        {
            Trainers = new List<Trainer>();
        }

        private static void Main()
        {
            ReadInputData(); // Read data for trainers and pokemons

            SwitchElements(); // Play pokemon

            Console.WriteLine(GetOutput()); // Print report
        }

        private static string GetOutput()
        {
            StringBuilder report = new StringBuilder();

            foreach (var trainer in Trainers.OrderByDescending(b => b.Badges))
            {
                report.AppendLine(trainer.ToString());
            }

            return report.ToString().Trim();
        }

        private static void SwitchElements()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                switch (line)
                {
                    case "Fire":
                        PlayGame("Fire");
                        break;

                    case "Water":
                        PlayGame("Water");
                        break;

                    case "Electricity":
                        PlayGame("Electricity");
                        break;
                }
            }
        }

        private static void PlayGame(string element)
        {
            foreach (Trainer trainer in Trainers)
            {
                if (trainer.PlayerHasPokemonWithElement(element))
                {
                    // Player has pokemon with this element so he earns a badge
                    trainer.Badges++;
                }
                else
                {
                    // All pokemons lose 10 pts from their power
                    trainer.ReducePokemonsPower();
                    trainer.RemoveDeadPokemons();
                }
            }
        }

        private static void ReadInputData()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Tournament")
                {
                    break;
                }

                string[] lineTokens = line.Split();

                Trainer existingTrainer = Trainers.FirstOrDefault(n => n.Name == lineTokens[0]);

                if (existingTrainer != null)
                {
                    // Update trainer pokemon list
                    existingTrainer.Pokemons.Add(new Pokemon(lineTokens[1], lineTokens[2], int.Parse(lineTokens[3])));
                }
                else
                {
                    // Trainer does not exist => create trainer, add pokemont to trainer and add trainer to trainers list
                    Trainer newTrainer = new Trainer(lineTokens[0]);
                    newTrainer.Pokemons.Add(new Pokemon(lineTokens[1], lineTokens[2], int.Parse(lineTokens[3])));
                    Trainers.Add(newTrainer);
                }
            }
        }
    }
}