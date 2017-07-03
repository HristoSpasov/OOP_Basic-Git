namespace _03.BankAccountTest
{
    internal class BankAccount
    {
        public BankAccount(int id)
        {
            this.Id = id;
            this.Amount = 0.0;
        }

        public int Id { get; }

        public double Amount { get; set; }
    }
}