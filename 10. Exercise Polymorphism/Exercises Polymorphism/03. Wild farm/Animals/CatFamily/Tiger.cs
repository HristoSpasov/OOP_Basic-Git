using System.Collections.Generic;

namespace _03.Wild_farm.Animals.CatFamily
{
    public class Tiger : CatFamily
    {
        private static readonly IEnumerable<string> foodEating = new List<string>() { "meat" };

        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }
    }
}