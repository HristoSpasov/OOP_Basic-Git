using System;

namespace _03.Mankind
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                string[] student = Console.ReadLine()
                    .Trim()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string[] worker = Console.ReadLine()
                    .Trim()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Human st = new Student(student[0], student[1], student[2]);
                Human w = new Worker(worker[0], worker[1], decimal.Parse(worker[2]), double.Parse(worker[3]));

                Console.WriteLine(st);
                Console.WriteLine(w);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}