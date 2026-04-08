namespace Order_processing_system;

public static class Validator
{
    public static bool Validate(Order order)
    {
        return order.Quantity > 0 && order.Price > 0;
    }
}