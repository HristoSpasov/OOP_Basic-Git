namespace _13.Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal static class Program
    {
        private static HashSet<Person> persons; // Here are stored persons with known name and birthday

        private static HashSet<string> familyTies; // Family tie data

        static Program()
        {
            persons = new HashSet<Person>();
            familyTies = new HashSet<string>();
        }

        private static void Main()
        {
            string personBirthdayOrName = Console.ReadLine();

            ReadAllInputData(); // Read all lines. Add known people to person list and unknown to family tie

            AnalyzeFamilyTies(); // Read family ties

            Console.WriteLine(GetFamilyTreeFor(personBirthdayOrName)); // Get and print family tree for specified person
        }

        private static string GetFamilyTreeFor(string personBirthdayOrName)
        {
            Person personToPrintFamilyTreeFor;

            if (personBirthdayOrName.Contains('/'))
            {
                // We will search the person by birthday
                personToPrintFamilyTreeFor = persons.FirstOrDefault(bd => bd.Birthday == personBirthdayOrName);
            }
            else
            {
                // We will search the person by name
                personToPrintFamilyTreeFor = persons.FirstOrDefault(n => n.Name == personBirthdayOrName);
            }

            StringBuilder report = new StringBuilder();

            report.AppendLine($"{personToPrintFamilyTreeFor.Name} {personToPrintFamilyTreeFor.Birthday}");
            report.AppendLine("Parents:");
            report.Append($"{string.Concat(personToPrintFamilyTreeFor.Parents)}");
            report.AppendLine("Children:");
            report.Append($"{string.Concat(personToPrintFamilyTreeFor.Children)}");

            return report.ToString().Trim();
        }

        private static void AnalyzeFamilyTies()
        {
            foreach (var tie in familyTies)
            {
                string[] tieTokens = tie.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                Person parrent;
                Person child;

                if (tieTokens[0].Contains('/') && tieTokens[1].Contains('/'))
                {
                    // We have two dates;
                    string parrentDate = tieTokens[0];
                    string childDate = tieTokens[1];

                    parrent = persons.First(d => d.Birthday == parrentDate);
                    child = persons.First(d => d.Birthday == childDate);
                }
                else if (!tieTokens[0].Contains('/') && !tieTokens[1].Contains('/'))
                {
                    // We have two names
                    string parrentName = tieTokens[0];
                    string childName = tieTokens[1];

                    parrent = persons.First(n => n.Name == parrentName);
                    child = persons.First(n => n.Name == childName);
                }
                else
                {
                    // We have one name and one birthday
                    if (tieTokens[0].Contains('/'))
                    {
                        // Parent has given birthday and child has given name
                        string parrentBirthday = tieTokens[0];
                        string childName = tieTokens[1];

                        parrent = persons.First(bd => bd.Birthday == parrentBirthday);
                        child = persons.First(n => n.Name == childName);
                    }
                    else
                    {
                        // Parrent has given name and child has given birthday
                        string parrentName = tieTokens[0];
                        string childBirthday = tieTokens[1];

                        parrent = persons.First(n => n.Name == parrentName);
                        child = persons.First(bd => bd.Birthday == childBirthday);
                    }
                }

                // Add parrent to child's parrent list and child to parrent's child list
                parrent.Children.Add(child);
                child.Parents.Add(parrent);

                // Remove old person data
                persons.RemoveWhere(n => n.Name == parrent.Name);
                persons.RemoveWhere(n => n.Name == child.Name);

                // Add updated person data to set
                persons.Add(parrent);
                persons.Add(child);
            }
        }

        private static void ReadAllInputData()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                if (line.Contains(" - "))
                {
                    // This is family tie
                    familyTies.Add(line);
                }
                else
                {
                    // This is person birthday line
                    string[] personTokens = line.Split();

                    string personName = personTokens[0] + " " + personTokens[1];
                    string birthday = personTokens[2];

                    persons.Add(new Person(personName, birthday));
                }
            }
        }
    }
}