namespace _06.Football_Team_Generator
{
    using System;
    using System.Text;

    internal class Program
    {
        private static readonly StringBuilder Output;

        static Program()
        {
            Output = new StringBuilder();
        }

        private static void Main()
        {
            ReadInput();

            Console.WriteLine(Output.ToString().Trim());
        }

        private static void ReadInput()
        {
            while (true)
            {
                try
                {
                    string line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }

                    if (line.StartsWith("Team"))
                    {
                        // Add new team
                        TeamDatabase.AddTeam(new Team(line.Split(';')[1]));
                    }

                    if (line.StartsWith("Add"))
                    {
                        // Try add player
                        string[] lineTokens = line.Split(';');

                        if (!TeamDatabase.TeamExists(lineTokens[1]))
                        {
                            throw new ArgumentException($"Team {lineTokens[1]} does not exist.");
                        }

                        Team teamToAddPlayer = TeamDatabase.GetTeam(lineTokens[1]);

                        teamToAddPlayer.AddPlayer(new Player(lineTokens[2], int.Parse(lineTokens[3]), int.Parse(lineTokens[4]), int.Parse(lineTokens[5]), int.Parse(lineTokens[6]), int.Parse(lineTokens[7])));
                    }

                    if (line.StartsWith("Remove"))
                    {
                        // Try remove player
                        string[] lineTokens = line.Split(';');

                        if (!TeamDatabase.TeamExists(lineTokens[1]))
                        {
                            throw new ArgumentException($"Team {lineTokens[1]} does not exist.");
                        }

                        Team teamToRemovePlayer = TeamDatabase.GetTeam(lineTokens[1]);

                        teamToRemovePlayer.RemovePlayer(lineTokens[2]);
                    }

                    if (line.StartsWith("Rating"))
                    {
                        // Try get rating
                        string[] lineTokens = line.Split(';');

                        if (!TeamDatabase.TeamExists(lineTokens[1]))
                        {
                            throw new ArgumentException($"Team {lineTokens[1]} does not exist.");
                        }

                        Team teamToGetRating = TeamDatabase.GetTeam(lineTokens[1]);

                        Output.AppendLine($"{teamToGetRating.Name} - {teamToGetRating.CalculateRating()}");
                    }
                }
                catch (ArgumentException e)
                {
                    Output.AppendLine(e.Message);
                }
            }
        }
    }
}