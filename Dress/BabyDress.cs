using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dress
{
    public class BabyDress
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

    }

    public class BabyDressUtility
    {
        public void AddressToCart(BabyDress dress, List<BabyDress> DressesCart)
        {
            DressesCart.Add(dress);
        }

        public bool RemoveDressFromCart(string brand, List<BabyDress> DressesCart)
        { 
            return DressesCart.RemoveAll(dress => dress.Brand == brand) > 0;
        }
    }
}