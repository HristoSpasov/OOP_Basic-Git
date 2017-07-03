namespace _03.BankAccountTest
{
    internal class CommandInterpreter : Database
    {
        protected void AddUser(int id)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                bankAccounts[id] = new BankAccount(id);
            }
            else
            {
                output.AppendLine("Account already exists");
            }
        }

        protected void Deposit(int id, double deposit)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                output.AppendLine("Account does not exist");
            }
            else
            {
                this.bankAccounts[id].Amount += deposit;
            }
        }

        protected void Withdraw(int id, double withdraw)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                output.AppendLine("Account does not exist");
            }
            else
            {
                if (this.bankAccounts[id].Amount - withdraw < 0)
                {
                    output.AppendLine("Insufficient balance");
                }
                else
                {
                    this.bankAccounts[id].Amount -= withdraw;
                }
            }
        }

        protected void Print(int id)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                output.AppendLine("Account does not exist");
            }
            else
            {
                output.AppendLine($"Account ID{this.bankAccounts[id].Id}, balance {this.bankAccounts[id].Amount:F2}");
            }
        }
    }
}