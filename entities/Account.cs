using nelio_dotnet.Entities.Exceptions;

namespace nelio_dotnet.Entities
{
  class Account
  {
    public int number { get; set; }
    public string holder { get; set; }
    public double balance { get; private set; }
    public double withdrawLimit { get; set; }

    public void Deposit(double amount)
    {
      this.balance += amount;
    }

    public void Withdraw(double amount)
    {
      if (amount > this.withdrawLimit)
      {
        throw new DomainException("You've exceeded your withdraw limit");
      }

      if (amount > this.balance)
      {
        throw new DomainException("There's not enough balance");
      }

      this.balance -= amount;
    }
  }
}
