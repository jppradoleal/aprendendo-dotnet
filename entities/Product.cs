namespace nelio_dotnet.Entities
{
  class Product
  {
    public string name { get; set; }
    public double price { get; set; }

    public override string ToString()
    {
      return $"{this.name}, ${this.price}";
    }
  }
}