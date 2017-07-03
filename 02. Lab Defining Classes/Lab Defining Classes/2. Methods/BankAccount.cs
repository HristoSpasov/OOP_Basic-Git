internal class BankAccount
{
    private int id;
    private double balance;

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }

    public override string ToString()
    {
        return $"Account {this.id}, balance {this.balance}";
    }
}