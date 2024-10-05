namespace FishTask
{

    public class Fish
    {

        public string Species { get; set; }
        public double PricePerFish { get; set; }
    }

    public class FishUtility : Fish
    {

        public void AddFish(string species, double pricePerFish)
        {

            //set the values to the properties of fish class
            this.Species = species;
            this.PricePerFish = pricePerFish;
        }

        public bool BuyFish()
        {

            //validate the fishes
            if ((Species == "ClownFish") || (Species == "GoldFish"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculatePrice(int numberOfFishes)
        {

            int additionalCharges = 0;
            if (Species == "ClownFish")
            {
                additionalCharges = 100;
            }
            else if (Species == "GoldFish")
            {
                additionalCharges = 150;
            }

            double totalPrice = (PricePerFish * numberOfFishes) + additionalCharges;

            return totalPrice;
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {

            FishUtility fishUtility = new FishUtility();

            Console.WriteLine("Enter the species to buy");
            string species = Console.ReadLine();

            if ((species == "ClownFish") || (species == "GoldFish"))
            {

                Console.WriteLine("Enter the price per fish");
                int pricePerFish = int.Parse(Console.ReadLine());

                fishUtility.AddFish(species, pricePerFish);

                fishUtility.BuyFish();

                Console.WriteLine("Enter number of fishes you need to buy");
                int numberOfFishes = int.Parse(Console.ReadLine());

                double totalCost = fishUtility.CalculatePrice(numberOfFishes);
                Console.WriteLine("Total cost is: " + totalCost);
            }
            else
            {
                Console.WriteLine($"{species} species not found");
            }

        }
    }
}
