namespace _03.Wild_farm.Animals.CatFamily
{
    public abstract class CatFamily : Animal
    {
        protected CatFamily(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
    }
}