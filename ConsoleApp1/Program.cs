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

            Console.WriteLine("Order created!");
        }
    }
}