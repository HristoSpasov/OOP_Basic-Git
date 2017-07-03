namespace _12.Google.Database
{
    using System;
    using System.Text.RegularExpressions;

    internal static class PersonDataReader
    {
        private static readonly string CompanyPattern = @"^(.+)\scompany\s(.+)\s(.+)\s(.+)$";

        private static readonly string PokemonPattern = @"^(.+)\spokemon\s(.+)$";

        private static readonly string ParentsPattern = @"^(.+)\sparents\s(.+)\s(.+)$";

        private static readonly string ChildPattern = @"^(.+)\schildren\s(.+)\s(.+)$";

        private static readonly string CarPattern = @"^(.+)\scar\s(.+)\s(.+)$";

        internal static void PersonReader()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                if (Regex.IsMatch(line, CompanyPattern))
                {
                    // We have a company info line
                    Match match = Regex.Match(line, CompanyPattern);
                    CompanyLineLogic(match);
                    continue;
                }

                if (Regex.IsMatch(line, PokemonPattern))
                {
                    // We have a pokemon info line
                    Match match = Regex.Match(line, PokemonPattern);
                    PokemonLineLogic(match);
                    continue;
                }

                if (Regex.IsMatch(line, ParentsPattern))
                {
                    // We have a parrent info line
                    Match match = Regex.Match(line, ParentsPattern);
                    ParrentLineLogic(match);
                    continue;
                }

                if (Regex.IsMatch(line, ChildPattern))
                {
                    // We have a child info line
                    Match match = Regex.Match(line, ChildPattern);
                    ChildLineLogic(match);
                    continue;
                }

                if (Regex.IsMatch(line, CarPattern))
                {
                    // We have a car info line
                    Match match = Regex.Match(line, CarPattern);
                    CarLineLogic(match);
                }
            }
        }

        private static void CarLineLogic(Match match)
        {
            string personName = match.Groups[1].Value;
            string carModel = match.Groups[2].Value;
            string carSpeed = match.Groups[3].Value;

            if (Database.PersonExists(personName))
            {
                // Update person data
                Person existisngPerson = Database.GetPerson(personName);
                existisngPerson.Car = new Car(carModel, carSpeed);

                Database.RemovePerson(personName); // Remove old person data

                Database.AddPerson(existisngPerson); // Add updated user data to set
            }
            else
            {
                // Add new person
                Person newPerson = new Person(personName) { Car = new Car(carModel, carSpeed) };

                Database.AddPerson(newPerson); // Add new person to database
            }
        }

        private static void ChildLineLogic(Match match)
        {
            string personName = match.Groups[1].Value;
            string childName = match.Groups[2].Value;
            string childBirthday = match.Groups[3].Value;

            if (Database.PersonExists(personName))
            {
                // Update person data
                Person existingPerson = Database.GetPerson(personName);
                existingPerson.Children.Add(new Child(childName, childBirthday));

                Database.RemovePerson(personName); // Remove old person data

                Database.AddPerson(existingPerson); // Add updated person data to set
            }
            else
            {
                // No person exists
                Person newPerson = new Person(personName);
                newPerson.Children.Add(new Child(childName, childBirthday));

                Database.AddPerson(newPerson); // Add to set
            }
        }

        private static void ParrentLineLogic(Match match)
        {
            string personName = match.Groups[1].Value;
            string parrentName = match.Groups[2].Value;
            string parrentBirthday = match.Groups[3].Value;

            if (Database.PersonExists(personName))
            {
                // Update person data
                Person existingPerson = Database.GetPerson(personName);
                existingPerson.Parents.Add(new Parent(parrentName, parrentBirthday));

                Database.RemovePerson(personName); // Remove old person data

                Database.AddPerson(existingPerson); // Add updated person data to set
            }
            else
            {
                // No person exists
                Person newPerson = new Person(personName);
                newPerson.Parents.Add(new Parent(parrentName, parrentBirthday));

                Database.AddPerson(newPerson); // Add to set
            }
        }

        private static void PokemonLineLogic(Match match)
        {
            string personName = match.Groups[1].Value;
            string pokemonName = match.Groups[2].Value;
            string pokemonType = match.Groups[3].Value;

            if (Database.PersonExists(personName))
            {
                // Person exists => add pokemon data to person
                Person existingPerson = Database.GetPerson(personName);
                existingPerson.Pokemons.Add(new Pokemon(pokemonName, pokemonType));

                Database.RemovePerson(personName); // Remove old person data

                Database.AddPerson(existingPerson); // Add updated person status to set
            }
            else
            {
                // Create new person and add to set
                Person newPerson = new Person(personName);
                newPerson.Pokemons.Add(new Pokemon(pokemonName, pokemonType));

                Database.AddPerson(newPerson); // Add to database;
            }
        }

        private static void CompanyLineLogic(Match match)
        {
            string personName = match.Groups[1].Value;
            string companyName = match.Groups[2].Value;
            string department = match.Groups[3].Value;
            double salary = double.Parse(match.Groups[4].Value);

            if (Database.PersonExists(personName))
            {
                // Update person company data
                Person existingPerson = Database.GetPerson(personName);
                existingPerson.Company = new Company(companyName, department, salary);

                Database.RemovePerson(personName); // Delete person

                Database.AddPerson(existingPerson); // Add updated value back to set
            }
            else
            {
                // Create new person with company data
                Person newPerson = new Person(personName) { Company = new Company(companyName, department, salary) };

                Database.AddPerson(newPerson); // Add new person to set
            }
        }
    }
}