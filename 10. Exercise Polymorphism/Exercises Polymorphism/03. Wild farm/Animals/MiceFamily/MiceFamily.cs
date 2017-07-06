namespace _03.Wild_farm.Animals
{
    public abstract class MiceFamily : Animal
    {
        protected MiceFamily(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
    }
}