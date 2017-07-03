namespace _03.BankAccountTest
{
    using System;

    internal class CommandReader : CommandInterpreter
    {
        public void StartReadingCommands()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] lineTokens = line.Split();

                switch (lineTokens[0])
                {
                    case "Create":
                        AddUser(int.Parse(lineTokens[1]));
                        break;

                    case "Deposit":
                        Deposit(int.Parse(lineTokens[1]), double.Parse(lineTokens[2]));
                        break;

                    case "Withdraw":
                        Withdraw(int.Parse(lineTokens[1]), double.Parse(lineTokens[2]));
                        break;

                    case "Print":
                        Print(int.Parse(lineTokens[1]));
                        break;
                }
            }
        }

        public void PrintReport()
        {
            System.Console.WriteLine(GetOutput());
        }
    }
}