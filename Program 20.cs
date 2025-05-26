using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = "";
    public decimal TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "Alice", TotalAmount = 150 },
            new Order { OrderId = 2, CustomerName = "Bob", TotalAmount = 80 },
            new Order { OrderId = 3, CustomerName = "Charlie", TotalAmount = 200 },
        };

        var filteredOrders = orders
            .Where(o => o.TotalAmount > 100)
            .Select(o => new { o.OrderId, o.CustomerName });

        foreach (var order in filteredOrders)
        {
            Console.WriteLine($"OrderId: {order.OrderId}, Customer: {order.CustomerName}");
        }
    }
}
