using System.Collections.Generic;

namespace _03.Wild_farm.Animals
{
    public class Mouse : MiceFamily
    {
        protected static IEnumerable<string> foodEating = new List<string>() { "vegetable" };

        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }
    }
}