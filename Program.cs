using System;
using System.Globalization;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      int triple;
      Calculator.Triple(a, out triple);
      Console.WriteLine(triple);

      // Ref e Out são code-smells!!!!
    }
  }
}
