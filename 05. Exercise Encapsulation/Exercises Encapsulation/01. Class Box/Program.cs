namespace _01.Class_Box
{
    using System;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        private static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            Box newBox = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine($"Surface Area - {newBox.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {newBox.LateralSurface():F2}");
            Console.WriteLine($"Volume - {newBox.Volume():F2}");
        }
    }
}