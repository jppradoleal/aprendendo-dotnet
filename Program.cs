using System;
using System.Collections.Generic;
using nelio_dotnet.Entities;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the number of employees: ");
      int n = int.Parse(Console.ReadLine());

      List<Employee> employees = new List<Employee>();

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nEmployee #{i + 1} data: ");
        Console.Write("Outsourced (y/n)? ");
        bool isOutsourced = Console.ReadLine().Equals("y");

        Employee e = isOutsourced ? new OutsourcedEmployee() : new Employee();

        Console.Write("Name: ");
        e.name = Console.ReadLine();

        Console.Write("Hours: ");
        e.hours = int.Parse(Console.ReadLine());

        Console.Write("Value per hour: ");
        e.valuePerHour = double.Parse(Console.ReadLine());

        if (isOutsourced)
        {
          Console.Write("Additional charge: ");
          ((OutsourcedEmployee)e).additionalCharge = double.Parse(Console.ReadLine());
        }

        employees.Add(e);
      }

      Console.WriteLine("\nPAYMENTS:");

      foreach (Employee e in employees)
      {
        Console.WriteLine(e);
      }
    }
  }
}
