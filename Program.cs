using System;
using System.Globalization;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("How many employees will be registered: ");
      int n = int.Parse(Console.ReadLine());

      List<Employee> employees = new List<Employee>();

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nEmployee #{i + 1} ");

        Console.Write("Id: ");
        int eId = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine());

        employees.Add(new Employee(eId, name, salary));
      }

      Console.Write("\nEnter the employee id that will have salary increase: ");
      int id = int.Parse(Console.ReadLine());

      Console.Write("Enter the percentage: ");

      Employee luckyGuy = employees.Find(x => x.Id == id);

      if (luckyGuy != null)
      {
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        luckyGuy.IncreaseSalary(percentage);
      }
      else
      {
        Console.WriteLine("This id doesn't exists");
      }

      Console.WriteLine("\nUpdated list of employees");
      foreach (Employee employee in employees)
      {
        Console.WriteLine(employee);
      }
    }
  }
}
