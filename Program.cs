using System;
using nelio_dotnet.Entities;
using nelio_dotnet.Entities.Exceptions;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter account data: ");

      Account acc = new Account();

      Console.Write("Number: ");
      acc.number = int.Parse(Console.ReadLine());

      Console.Write("Holder: ");
      acc.holder = Console.ReadLine();

      Console.Write("Initial balance: ");
      acc.Deposit(double.Parse(Console.ReadLine()));

      Console.Write("Withdraw limit: ");
      acc.withdrawLimit = double.Parse(Console.ReadLine());

      try
      {
        Console.Write("Enter amount for withdraw: ");
        acc.Withdraw(double.Parse(Console.ReadLine()));

        Console.WriteLine($"New balance: {acc.balance}");
      }
      catch (DomainException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
