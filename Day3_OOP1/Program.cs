using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_OOP1
{
    internal class Program
    {
        static void Main(string[] args) { 
            Product product1 = new Product();
            product1.ProductName = "Table";
            product1.CategoryId = 2;
            product1.Id = 1;
            product1.UnitPrice = 258;
            product1.UnitInStock = 20;

            Product product2 = new Product { UnitInStock = 10, UnitPrice = 501, 
                Id = 2 , CategoryId = 3, ProductName = "Chair" };

            //Case Sensitive
            //PascalCase    // CamelCase
            ProductManager productManager = new ProductManager();
            productManager.add(product1);
            //string, is an referrance type
            Console.WriteLine(product1.ProductName);
            Console.WriteLine("---------------");

            //int, boolean, float are value type.
            //I wanted to show them in those method.
            int a = 100;
            productManager.doSomething(a);
            Console.WriteLine(a);

        }
   
    }

}
