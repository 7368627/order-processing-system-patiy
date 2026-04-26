using Order_processing_system;
using Xunit;    

public class OrderServiceTests
{
    [Fact]
    public void CalculateTotal_ShouldReturnCorrectValue()
    {
        var order = new Order
        {
            Quantity = 2,
            Price = 100
        };

        var result = OrderService.CalculateTotal(order);

        Assert.Equal(180, result); // 200 - 10% discount
    }
}