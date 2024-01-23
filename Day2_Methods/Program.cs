using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Methods
{
    internal class Program
    {
    static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Description = "Apple Explanation";
            product1.Price = 100;
            product1.Id = 1;

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Description = "Watermelon Explanation";
            product2.Price = 250;
            product2.Id = 2;

            Product[] products = { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Id);
                Console.WriteLine("-------------------");
            }
            ProductManager productManager = new ProductManager();
            productManager.addProduct(product1);
            productManager.addProduct(product2);


        }


    }


}
