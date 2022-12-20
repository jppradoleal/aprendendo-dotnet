namespace nelio_dotnet.Entities
{
  class Product
  {
    public string name { get; set; }
    public double price { get; set; }

    public virtual string PriceTag()
    {
      return $"{this.name} $ {this.price:F2}";
    }

    public override string ToString()
    {
      return this.PriceTag();
    }
  }
}