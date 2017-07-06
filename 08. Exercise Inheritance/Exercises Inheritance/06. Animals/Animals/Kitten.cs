namespace _05.Mordor_s_Cruelty_Plan.Animals
{
    internal class Kitten : Cat
    {
        public Kitten(string name, string age) : base(name, age, "Female")
        {
        }

        protected override string ProduceSound()
        {
            return "Miau";
        }
    }
}