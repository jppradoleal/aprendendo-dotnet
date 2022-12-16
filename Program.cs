using System;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira a quantidade: ");
      int n = int.Parse(Console.ReadLine());

      int inside = 0;
      int outside = 0;

      for (int i = 0; i < n; i++)
      {
        int m = int.Parse(Console.ReadLine());
        if (m >= 10 && m <= 20)
        {
          inside++;
          continue;
        }
        outside++;
      }

      Console.WriteLine($"{inside} in");
      Console.WriteLine($"{outside} out");
    }
  }
}
