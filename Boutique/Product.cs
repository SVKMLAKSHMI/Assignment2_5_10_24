using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boutique
{
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }

        public Product(string name, int stock)
        {
            this.Name = name;
            this.Stock = stock;
        }
    }

    public class DelieveryService
    {
        public bool PlaceOrder(Product product)
        {
            if(product.Stock > 0)
            {
                return true;
            }
            else
            {
                throw new ProductOutOfStockException("Product out of stock");
            }
        }
    }

    public class ProductOutOfStockException : Exception
    {
        //public ProductOutOfStockException() : base("product is out of stock") { }

        string message = string.Empty;
        public ProductOutOfStockException(string msg) : base(msg) 
        {
            message = msg;

        }
        //public override string Message => "Product is out of stock";
    }
}
