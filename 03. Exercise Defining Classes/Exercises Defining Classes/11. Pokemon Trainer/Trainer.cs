namespace _11.Pokemon_Trainer
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public bool PlayerHasPokemonWithElement(string element)
        {
            return this.Pokemons.Any(pe => pe.Element == element);
        }

        public void ReducePokemonsPower()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].Health -= 10;
            }
        }

        public void RemoveDeadPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                if (this.Pokemons[i].Health <= 0)
                {
                    this.Pokemons.RemoveAt(i);
                    i = -1;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }
}