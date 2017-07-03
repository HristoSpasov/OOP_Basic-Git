namespace _02.Class_Box_Data_Validation
{
    using System;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        internal static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                Box newBox = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

                Console.WriteLine($"Surface Area - {newBox.SurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {newBox.LateralSurface():F2}");
                Console.WriteLine($"Volume - {newBox.Volume():F2}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}