using System;

namespace Order_processing_system{
    

    
    class Program
    {
        static void Main()
        {
            Console.Write("Product: ");
            string name = Console.ReadLine();

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            var order = new Order
            {
                ProductName = name,
                Quantity = quantity,
                Price = price
            };

            if (Validator.Validate(order))
            {  Console.Write("Order created!");
               Console.WriteLine("\tTotal sum: " + OrderService.CalculateTotal(order));
            }
            else
            {
                Console.WriteLine("Order could not be created!");
            }
            
        }
    }
}