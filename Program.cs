using System;
using System.Globalization;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class BankAccount
  {
    private static double TAX = 5.0;

    public int accountNumber { get; private set; }
    public string ownerName;
    private double balance;

    public BankAccount(int accountNumber, string ownerName, double initialBalance)
    {
      this.accountNumber = accountNumber;
      this.ownerName = ownerName;
      this.balance = 0;
      this.Deposit(initialBalance);
    }

    public BankAccount(int accountNumber, string ownerName)
    {
      this.accountNumber = accountNumber;
      this.ownerName = ownerName;
      this.balance = 0;
    }

    public Double Withdraw(double amount)
    {
      if (amount < 0)
      {
        throw new InvalidOperationException("Amount must be greater than 0.");
      }

      this.balance -= amount + BankAccount.TAX;
      return this.balance;
    }

    public Double Deposit(double amount)
    {
      if (amount < 0)
      {
        throw new InvalidOperationException("Amount must be greater than 0.");
      }

      this.balance += amount;

      return this.balance;
    }

    public override string ToString()
    {
      return $"Conta: {this.accountNumber}, Titular: {this.ownerName}, Saldo: $ {this.balance:F2}";
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      BankAccount account;

      Console.Write("Entre o número da conta: ");
      int accountNumber = int.Parse(Console.ReadLine());

      Console.Write("Entre o titular da conta: ");
      string ownerName = Console.ReadLine();

      Console.Write("Haverá depósito inicial (s/n)? ");
      if (Console.ReadLine().Equals("s"))
      {
        Console.Write("Entre o valor de depósito inicial: ");
        double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        account = new BankAccount(accountNumber, ownerName, initialDeposit);
      }
      else
      {
        account = new BankAccount(accountNumber, ownerName);
      }

      Console.WriteLine("\nDados da conta:");
      Console.WriteLine(account.ToString());

      Console.Write("\nEntre um valor para depósito: ");
      double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      account.Deposit(amount);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(account.ToString());

      Console.Write("\nEntre um valor para saque: ");
      amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      account.Withdraw(amount);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(account.ToString());
    }
  }
}
