using System;

namespace nelio_dotnet.Entities
{
  class HourContract
  {
    public DateTime date { get; set; }
    public double valuePerHour { get; set; }
    public int hours { get; set; }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
      this.date = date;
      this.valuePerHour = valuePerHour;
      this.hours = hours;
    }

    public double TotalValue()
    {
      return this.hours * this.valuePerHour;
    }
  }
}
