using System;
using System.Collections.Generic;
using nelio_dotnet.Entities;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the number of products: ");
      int n = int.Parse(Console.ReadLine());

      List<Product> products = new List<Product>();

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nProduct #{i + 1} data: ");
        Console.Write("Common, used or imported (c/u/i)? ");
        string type = Console.ReadLine();

        Product p;

        if (type.Equals("c"))
        {
          p = new Product();
        }
        else if (type.Equals("u"))
        {
          p = new UsedProduct();
        }
        else if (type.Equals("i"))
        {
          p = new ImportedProduct();
        }
        else
        {
          throw new ArgumentException("Type unrecognizable");
        }

        Console.Write("Name: ");
        p.name = Console.ReadLine();

        Console.Write("Price: ");
        p.price = double.Parse(Console.ReadLine());

        if (p is UsedProduct)
        {
          Console.Write("Manufacture date (dd/MM/yyyy): ");
          ((UsedProduct)p).manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }
        else if (p is ImportedProduct)
        {
          Console.Write("Custom fee: ");
          ((ImportedProduct)p).customFee = double.Parse(Console.ReadLine());
        }

        products.Add(p);
      }

      Console.WriteLine("\nPRICE TAGS:");

      foreach (Product p in products)
      {
        Console.WriteLine(p);
      }
    }
  }
}
