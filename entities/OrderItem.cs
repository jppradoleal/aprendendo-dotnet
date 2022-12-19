namespace nelio_dotnet.Entities
{
  class OrderItem
  {
    public int quantity { get; set; }
    public Product product;

    public double SubTotal()
    {
      return this.product.price * this.quantity;
    }

    public override string ToString()
    {
      return $"{this.product}, Quantity: {this.quantity}, Subtotal: ${this.SubTotal()}";
    }
  }
}
