using System;
using System.Linq;
using System.Collections.Generic;
using nelio_dotnet.Entities.Enums;

namespace nelio_dotnet.Entities
{
  class Worker
  {
    public string name { get; set; }
    public WorkerLevel level { get; set; }
    public double baseSalary { get; set; }
    public Department department { get; set; }
    public List<HourContract> contracts { get; set; }

    public Worker(string name, Department department, WorkerLevel level, double baseSalary)
    {
      this.name = name;
      this.level = level;
      this.department = department;
      this.baseSalary = baseSalary;
      this.contracts = new List<HourContract>();
    }

    public void AddContract(HourContract contract)
    {
      this.contracts.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
      this.contracts.Remove(contract);
    }

    public double Income(int year, int month)
    {
      return this.contracts
                 .FindAll(x => x.date.Year == year && x.date.Month == month)
                 .Aggregate(0d, (total, x) => total += x.TotalValue()) + this.baseSalary;
    }
  }
}
