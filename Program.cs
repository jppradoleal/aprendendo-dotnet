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
      Calculator.Triple(ref a);
      Console.WriteLine(a);
    }
  }
}
