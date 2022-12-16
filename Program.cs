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

      for (int i = 0; i < n; i++)
      {
        string[] nums = Console.ReadLine().Split(" ");
        float den = float.Parse(nums[1]);
        if (den == 0)
        {
          Console.WriteLine("divisão impossível");
          continue;
        }

        Console.WriteLine(float.Parse(nums[0]) / den);
      }
    }
  }
}
