namespace _07.Speed_Racing
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            ReadCarInputData();
            DriveCars();

            Console.WriteLine(Car.GetCarsReport());
        }

        private static void DriveCars()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] driveTokens = line.Split();

                Car.TryDrive(driveTokens[1], double.Parse(driveTokens[2]));
            }
        }

        private static void ReadCarInputData()
        {
            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carTokens = Console.ReadLine().Split();

                new Car(carTokens[0], double.Parse(carTokens[1]), double.Parse(carTokens[2])).Add();
            }
        }
    }
}