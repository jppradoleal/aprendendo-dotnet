using System;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira o valor: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}
