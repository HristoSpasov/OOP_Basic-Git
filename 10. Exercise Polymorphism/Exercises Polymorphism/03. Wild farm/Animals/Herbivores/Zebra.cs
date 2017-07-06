using System.Collections.Generic;

namespace _03.Wild_farm.Animals.Herbivores
{
    public class Zebra : Herbivore
    {
        protected static IEnumerable<string> foodEating = new List<string>() { "vegetable" };

        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Zs";
        }
    }
}