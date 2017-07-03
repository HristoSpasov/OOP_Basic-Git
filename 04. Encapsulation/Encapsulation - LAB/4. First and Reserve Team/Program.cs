using System;

internal class Program
{
    private static void Main()
    {
        Team newTeam = new Team("The pirates");

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] tokens = Console.ReadLine().Split();

            Person newPerson = new Person(tokens[0], tokens[1], int.Parse(tokens[2]), double.Parse(tokens[3]));
            newTeam.AddPlayer(newPerson);
        }

        Console.WriteLine($"First team has {newTeam.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team has {newTeam.ReserveTeam.Count} players");
    }
}