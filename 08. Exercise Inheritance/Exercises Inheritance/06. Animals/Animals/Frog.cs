namespace _05.Mordor_s_Cruelty_Plan.Animals
{
    internal class Frog : Animal
    {
        public Frog(string name, string age, string gender) : base(name, age, gender)
        {
        }

        protected override string ProduceSound()
        {
            return "Frogggg";
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.ProduceSound()}\n";
        }
    }
}