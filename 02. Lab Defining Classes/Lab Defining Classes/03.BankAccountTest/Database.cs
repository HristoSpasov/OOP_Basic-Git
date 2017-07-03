namespace _03.BankAccountTest
{
    using System.Collections.Generic;
    using System.Text;

    internal class Database
    {
        protected Dictionary<int, BankAccount> bankAccounts = new Dictionary<int, BankAccount>();

        protected StringBuilder output = new StringBuilder();

        protected string GetOutput()
        {
            return output.ToString();
        }
    }
}