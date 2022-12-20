namespace nelio_dotnet.Entities
{
  class Employee
  {
    public string name { get; set; }
    public int hours { get; set; }
    public double valuePerHour { get; set; }

    public virtual double Payment()
    {
      return hours * valuePerHour;
    }

    public override string ToString()
    {
      return $"{this.name} - $ {this.Payment():F2}";
    }
  }
}