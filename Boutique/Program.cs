namespace Boutique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DelieveryService delieveryService = new DelieveryService();

            DelieveryService deliveryService = new DelieveryService();

            Console.WriteLine("Enter the product name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of stocks");
            int stocks = int.Parse(Console.ReadLine());

            Product product = new Product(name, stocks);

            //deliveryService.PlaceOrder(product);

            try
            {
                bool orderPlaced = deliveryService.PlaceOrder(product);
                if (orderPlaced)
                {
                    Console.WriteLine("Order placed successfully");
                }
            }
            catch(ProductOutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}
