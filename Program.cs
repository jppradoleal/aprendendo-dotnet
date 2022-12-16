using System;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Employee
  {
    public string nome;
    public float wage;

    public Employee(string nome, float wage)
    {
      this.nome = nome;
      this.wage = wage;
    }


  }
  class Program
  {
    static void Main(string[] args)
    {
      Employee[] employees = new Employee[2];
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine($"Dados do {i + 1}º funcionário");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        Console.Write("Salário: ");
        float wage = float.Parse(Console.ReadLine());
        employees[i] = new Employee(name, wage);
      }

      Console.WriteLine($"Salário médio: {(employees[0].wage + employees[1].wage) / 2}");
    }
  }
}
