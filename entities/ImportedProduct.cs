namespace nelio_dotnet.Entities
{
  class ImportedProduct : Product
  {
    public double customFee { get; set; }

    public double TotalPrice()
    {
      return this.price + this.customFee;
    }

    public override string PriceTag()
    {
      return $"{base.PriceTag()} (Custom fee: $ {this.customFee})";
    }
  }
}