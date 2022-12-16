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

      int sum = 1;
      for (int i = n; i > 0; i--)
      {
        sum *= i;
      }

      Console.WriteLine(sum);
    }
  }
}
