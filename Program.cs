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

      List<float> medias = new List<float>();

      for (int i = 0; i < n; i++)
      {
        string[] notas = Console.ReadLine().Split(" ");
        float mediaAtual = (float.Parse(notas[0]) * 2 + float.Parse(notas[1]) * 3 + float.Parse(notas[2]) * 5) / 10;
        medias.Add(mediaAtual);
      }

      Console.WriteLine(String.Join(", ", medias));
    }
  }
}
