using System;
using System.Globalization;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Sum of 5, 4, 3, 2, 1: {Calculator.Sum(5, 4, 3, 2, 1)}");
    }
  }
}
