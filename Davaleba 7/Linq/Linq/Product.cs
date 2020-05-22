using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public double price { set; get; }
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>()
                {
                    new Product {id=1, name="Fanta", price=2.50},
                    new Product {id=2, name="Coca-Cola", price=2.70},
                    new Product {id=3, name="Sprite", price=2.60},
                    new Product {id=4, name="Boom", price=1.00},
                    new Product {id=5, name="Pepsi", price=2.75}
                };
            return products;
        }
    }
}
