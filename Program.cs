using System;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira o máximo: ");
      int x = int.Parse(Console.ReadLine());

      for (int i = 1; i <= x; i += 2)
      {
        Console.WriteLine(i);
      }
    }
  }
}
