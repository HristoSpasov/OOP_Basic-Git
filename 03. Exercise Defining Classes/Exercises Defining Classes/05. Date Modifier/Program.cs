namespace _05.Date_Modifier
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            DateModifier newModifier = new DateModifier(Console.ReadLine(), Console.ReadLine());

            Console.WriteLine(newModifier.CalculateDifferenceInDays());
        }
    }
}