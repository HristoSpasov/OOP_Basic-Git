namespace _03.BankAccountTest
{
    internal class BankAccountTest
    {
        public static void Main()
        {
            CommandReader program = new CommandReader();

            program.StartReadingCommands();

            program.PrintReport();
        }
    }
}