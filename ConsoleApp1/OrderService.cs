namespace Order_processing_system;

public class OrderService
{
    static public decimal CalculateTotal(Order order)
    {
        if(order == null)
            throw new ArgumentNullException(nameof(order));

        Console.WriteLine("Processing order...");

        return order.Quantity * order.Price;
    }
}