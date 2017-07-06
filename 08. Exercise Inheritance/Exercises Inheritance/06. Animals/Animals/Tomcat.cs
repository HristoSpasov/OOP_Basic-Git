namespace _05.Mordor_s_Cruelty_Plan.Animals
{
    internal class Tomcat : Cat
    {
        public Tomcat(string name, string age) : base(name, age, "Male")
        {
        }

        protected override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}