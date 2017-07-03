namespace _06.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Team
    {
        private string name;
        private List<Player> players;

        internal Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        private IReadOnlyCollection<Player> Players
        {
            get { return this.players.AsReadOnly(); }
            set { this.players = value.ToList(); }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = this.Players.FirstOrDefault(n => n.Name == playerName);

            if (playerToRemove == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(playerToRemove);
        }

        public int CalculateRating()
        {
            return this.Players.Any() ? (int)Math.Round(this.Players.Select(r => r.GetPlayerSkill()).Average()) : 0;
        }
    }
}