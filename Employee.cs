namespace nelio_dotnet
{
  class Employee
  {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public double Salary { get; private set; }

    public Employee(int Id, string Name, double Salary)
    {
      this.Id = Id;
      this.Name = Name;
      this.Salary = Salary;
    }

    public double IncreaseSalary(double percentage)
    {
      this.Salary *= 1 + (percentage / 100);
      return this.Salary;
    }

    public override string ToString()
    {
      return $"{Id}, {Name}, {Salary:F2}";
    }
  }
}