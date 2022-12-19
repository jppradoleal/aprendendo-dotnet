using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using nelio_dotnet.Entities.Enums;

namespace nelio_dotnet.Entities
{
  class Order
  {
    public DateTime moment { get; set; }
    public OrderStatus status { get; set; }
    public List<OrderItem> items { get; set; }
    public Client client { get; set; }

    public Order()
    {
      this.items = new List<OrderItem>();
      this.moment = DateTime.Now;
    }

    public void AddItem(OrderItem item)
    {
      this.items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
      this.items.Remove(item);
    }

    public double Total()
    {
      return this.items.Aggregate(0d, (total, item) => total += item.SubTotal());
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("ORDER SUMMARY: ");
      sb.AppendLine($"Order moment: {this.moment}");
      sb.AppendLine($"Order status: {this.status}");
      sb.AppendLine($"Client: {this.client}");
      sb.AppendLine("Order items: ");

      foreach (OrderItem item in this.items)
      {
        sb.AppendLine(item.ToString());
      }

      sb.AppendLine($"Total price: ${this.Total():F2}");

      return sb.ToString();
    }
  }
}