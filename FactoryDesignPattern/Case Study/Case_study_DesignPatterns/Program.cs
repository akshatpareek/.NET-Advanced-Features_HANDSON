using System;

namespace Case_study_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string channel, productType;
            MainFactory mainFactory = new MainFactory();
            Order order = null;

            Console.WriteLine("Channels: Agent,Ecommerce \nproduct Type: Toy, Furniture, Electronic");
            Console.WriteLine("Enter Channel and Product type:");
            channel = Console.ReadLine();
            productType = Console.ReadLine();

            order = mainFactory.getOrder(channel, productType);
            order.ProcessOrder();
        }
    }
}
