using System;

namespace nelio_dotnet.Entities
{
  class UsedProduct : Product
  {
    public DateTime manufactureDate { get; set; }

    public override string PriceTag()
    {
      return $"{this.name} (used) $ {this.price:F2} (Manufacture date: {this.manufactureDate.ToString("dd/MM/yyyy")})";
    }
  }
}