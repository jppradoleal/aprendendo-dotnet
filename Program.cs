using System;
using nelio_dotnet.Entities;
using nelio_dotnet.Entities.Enums;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the department's name: ");
      Department department = new Department { name = Console.ReadLine() };

      Console.WriteLine("\nEnter the worker data: ");
      Console.Write("Name: ");
      string workerName = Console.ReadLine();

      Console.Write("Level (Junior, MidLevel, Senior): ");
      WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

      Console.Write("Base salary: ");
      double workerBaseSalary = double.Parse(Console.ReadLine());

      Worker worker = new Worker(workerName, department, workerLevel, workerBaseSalary);

      Console.Write($"How many contracts {workerName} has? ");
      int workerContractsAmount = int.Parse(Console.ReadLine());

      for (int i = 0; i < workerContractsAmount; i++)
      {
        Console.WriteLine($"\nEnter #{i + 1} contract data: ");
        Console.Write("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());

        Console.Write("Duration (hours): ");
        int hours = int.Parse(Console.ReadLine());

        worker.contracts.Add(new HourContract(date, valuePerHour, hours));
      }

      Console.Write("\nEnter the month and year to calculate income (MM/YYYY): ");
      DateTime filteredDate = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", null);

      double totalIncomeForMonth = worker.Income(filteredDate.Year, filteredDate.Month);

      Console.WriteLine($"Name: {worker.name}");
      Console.WriteLine($"Department: {worker.department.name}");
      Console.WriteLine($"Income for {filteredDate.Month}/{filteredDate.Year}: {totalIncomeForMonth}");
    }
  }
}
