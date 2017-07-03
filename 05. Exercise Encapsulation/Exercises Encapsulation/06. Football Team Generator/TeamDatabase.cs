namespace _06.Football_Team_Generator
{
    using System.Collections.Generic;
    using System.Linq;

    internal static class TeamDatabase
    {
        private static readonly List<Team> Teams;

        static TeamDatabase()
        {
            Teams = new List<Team>();
        }

        public static void AddTeam(Team newTeam)
        {
            Teams.Add(newTeam);
        }

        public static bool TeamExists(string newTeamName)
        {
            return Teams.FirstOrDefault(n => n.Name == newTeamName) != null;
        }

        public static int GetStats(string teamName)
        {
            return (int)Teams.FirstOrDefault(n => n.Name == teamName).CalculateRating();
        }

        public static Team GetTeam(string searchTeam)
        {
            return Teams.FirstOrDefault(n => n.Name == searchTeam);
        }
    }
}