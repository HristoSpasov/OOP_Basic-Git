namespace _01.Define_a_class_Person
{
    using System;
    using System.Reflection;

    internal class Program
    {
        private static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}