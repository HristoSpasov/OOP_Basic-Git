namespace _05.Mordor_s_Cruelty_Plan.Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, string age, string gender) : base(name, age, gender)
        {
        }

        protected override string ProduceSound()
        {
            return "MiauMiau";
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.ProduceSound()}\n";
        }
    }
}