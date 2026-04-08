namespace Order_processing_system;

public class OrderService
{
    static public decimal CalculateTotal(Order order)
    {
        return order.Quantity * order.Price;
    }
}