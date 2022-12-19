using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite o numero de linhas e colunas: ");
      string[] dimensions = Console.ReadLine().Split(" ");
      int w = int.Parse(dimensions[0]);
      int h = int.Parse(dimensions[1]);

      int[,] matrix = new int[w, h];

      for (int i = 0; i < w; i++)
      {
        Console.Write($"Digite os elementos da linha #{i + 1}: ");
        int[] numeros = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

        for (int j = 0; j < h; j++)
        {
          matrix[i, j] = numeros[j];
        }
      }

      Console.Write("Digite o número que deseja buscar: ");
      int target = int.Parse(Console.ReadLine());

      for (int i = 0; i < w; i++)
      {
        for (int j = 0; j < h; j++)
        {
          if (matrix[i, j] == target)
          {
            Console.WriteLine($"Position {i},{j}:");
            Program.PrintNeighbours(matrix, j, i);
          }
        }
      }
    }

    static void PrintNeighbours(int[,] matrix, int posX, int posY)
    {
      if (posY > 0)
      {
        Console.WriteLine($"Up: {matrix[posY - 1, posX]}");
      }
      if (posX < matrix.GetLength(0) - 1)
      {
        Console.WriteLine($"Right: {matrix[posY, posX + 1]}");
      }
      if (posY < matrix.GetLength(1) - 1)
      {
        Console.WriteLine($"Down: {matrix[posY + 1, posX]}");
      }
      if (posX > 0)
      {
        Console.WriteLine($"Left: {matrix[posY, posX - 1]}");
      }
    }
  }
}
