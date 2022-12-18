using System;
using System.Globalization;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Student[] rooms = new Student[10];

      Console.Write("How many rooms will be rented? ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nRent #{i + 1}");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Room: ");
        int room = int.Parse(Console.ReadLine());

        rooms[room] = new Student(name, email);
      }

      Console.WriteLine("\nBusy rooms:");
      for (int i = 0; i < 10; i++)
      {
        if (rooms[i] != null)
        {
          Console.WriteLine($"{i}: {rooms[i]}");
        }
      }
    }
  }
}
