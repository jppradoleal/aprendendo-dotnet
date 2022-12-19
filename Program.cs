using System;
using nelio_dotnet.Entities;
using nelio_dotnet.Entities.Enums;

namespace nelio_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Client client = new Client();

      Console.WriteLine("Enter the client data: ");

      Console.Write("Name: ");
      client.name = Console.ReadLine();

      Console.Write("Email: ");
      client.email = Console.ReadLine();

      Console.Write("Birth date (DD/MM/YYYY): ");
      client.birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

      Console.WriteLine("\nEnter the order data: ");
      Order order = new Order();
      order.client = client;

      Console.Write("Status: ");
      order.status = Enum.Parse<OrderStatus>(Console.ReadLine());

      Console.Write("How many items to this order: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
        OrderItem orderItem = new OrderItem();
        orderItem.product = new Product();

        Console.WriteLine($"\nEnter #{i + 1} item data: ");
        Console.Write("Product name: ");
        orderItem.product.name = Console.ReadLine();

        Console.Write("Product price: ");
        orderItem.product.price = double.Parse(Console.ReadLine());

        Console.Write("Quantity: ");
        orderItem.quantity = int.Parse(Console.ReadLine());

        order.AddItem(orderItem);
      }

      Console.WriteLine($"\n{order}");
    }
  }
}
