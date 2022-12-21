using System;
using System.Linq;
using System.Collections.Generic;
using nelio_dotnet.Entities;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the number of tax payers: ");
      int n = int.Parse(Console.ReadLine());

      List<TaxPayer> taxPayers = new List<TaxPayer>();

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nTax payer #{i + 1} data");

        TaxPayer p;

        Console.Write("Individual or company? ");
        bool isIndividual = Console.ReadLine().Equals("i");

        if (isIndividual)
        {
          p = new Individual();
        }
        else
        {
          p = new Company();
        }

        Console.Write("Name: ");
        p.name = Console.ReadLine();

        Console.Write("Anual income: ");
        p.anualIncome = double.Parse(Console.ReadLine());

        if (p is Individual)
        {
          Console.Write("Health expenditures? ");
          ((Individual)p).healthExpenditures = double.Parse(Console.ReadLine());
        }
        else if (p is Company)
        {
          Console.Write("Number of employees? ");
          ((Company)p).employeesAmount = int.Parse(Console.ReadLine());
        }
        else
        {
          throw new ArgumentException("Invalid type");
        }

        taxPayers.Add(p);
      }

      Console.WriteLine("\nTAXES PAID:");

      foreach (TaxPayer p in taxPayers)
      {
        Console.WriteLine(p);
      }

      double total = taxPayers.Aggregate(0d, (total, payer) => total += payer.CalcularImposto());

      Console.WriteLine($"\nTOTAL TAXES: $ {total}");
    }
  }
}
