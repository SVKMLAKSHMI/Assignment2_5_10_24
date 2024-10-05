using System.Collections.Generic;
using System.Transactions;
namespace Dress
{
    public class Program
    {
        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();
        public static void Main(string[] args)
        {
            BabyDressUtility babyDressUtility = new BabyDressUtility();

            Console.WriteLine("1. Add dress to cart \n2. Remov dress from cart \n3.Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            while ((choice > 0) && (choice < 3))
            {
                switch (choice)
                {
                    case 1:
                        BabyDress newDress = new BabyDress();

                        Console.WriteLine("Enter the dress size");
                        newDress.Size = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the dress color");
                        newDress.Color = Console.ReadLine();

                        Console.WriteLine("Enter the dress brand");
                        newDress.Brand = Console.ReadLine();

                        Console.WriteLine("Enter the dress price");
                        newDress.Price = double.Parse(Console.ReadLine());

                        babyDressUtility.AddressToCart(newDress, DressesCart);

                        Console.WriteLine("Successfully removed from the cart");

                        break;

                    case 2:
                        Console.WriteLine("Entrer the dress brand to remove from the cart");
                        string brand = Console.ReadLine();

                        if (babyDressUtility.RemoveDressFromCart(brand, DressesCart))
                        {
                            Console.WriteLine("Successfully removed from the cart");
                        }
                        else
                        {
                            Console.WriteLine("Dress not found in the cart");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Thank You");
                        break;
                }
            }
            
        }
    }
}
