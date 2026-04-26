namespace Order_processing_system;

public class OrderService
{
    static public decimal CalculateTotal(Order order)
    {
        if (order == null)
            throw new ArgumentNullException(nameof(order));

        Console.WriteLine("Processing order...");
        Console.WriteLine($"Quantity: {order.Quantity}");
        Console.WriteLine($"Price: {order.Price}");

        decimal total = order.Quantity * order.Price;

        decimal discount = 0.1m; // 10% discount

        Console.WriteLine($"Discount applied: {discount * 100}%");

        return total - (total * discount);
    }
}