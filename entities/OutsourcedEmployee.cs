namespace nelio_dotnet.Entities
{
  class OutsourcedEmployee : Employee
  {
    public double additionalCharge { get; set; }

    public override double Payment()
    {
      return base.Payment() + (this.additionalCharge * 1.1);
    }
  }
}