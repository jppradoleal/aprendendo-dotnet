using System;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira as linhas: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
        Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
      }
    }
  }
}
