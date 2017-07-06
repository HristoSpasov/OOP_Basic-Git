namespace _03.Wild_farm.Animals.Herbivores
{
    public abstract class Herbivore : Animal
    {
        protected Herbivore(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
    }
}