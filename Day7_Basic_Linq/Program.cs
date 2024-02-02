using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Basic_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
               new Category() {CategoryId = 1, CategoryName = "Computer" },
               new Category() {CategoryId = 2, CategoryName = "Phone" }

            };
            List<Product> products = new List<Product>()
            {
               new Product(){ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32GB Ram", UnitPrice = 6000, UnitInStock = 5},
               new Product(){ProductId = 2, CategoryId = 1, ProductName = "Monster Laptop", QuantityPerUnit = "32GB Ram", UnitPrice = 4000, UnitInStock = 5},
               new Product(){ProductId = 3, CategoryId = 1, ProductName = "HB Laptop", QuantityPerUnit = "32GB Ram", UnitPrice = 7000, UnitInStock = 5},
               new Product(){ProductId = 4, CategoryId = 2, ProductName = "Xiaomi Phone", QuantityPerUnit = "4GB Ram", UnitPrice = 1000, UnitInStock = 5},
               new Product(){ProductId = 5, CategoryId = 2, ProductName = "Apple Phone", QuantityPerUnit = "3GB Ram", UnitPrice = 1500, UnitInStock = 5}
            };
            Product product = new Product() { ProductId = 6, CategoryId = 2, ProductName = "Samsung Phone", QuantityPerUnit = "4GB Ram", UnitPrice = 2000, UnitInStock = 11 };
            products.Add(product);
            Console.WriteLine("-----------------");
            AnyTest(products);
            Console.WriteLine("-----------------");
            FindTest(products, product);
            Console.WriteLine("-----------------");
            FindAllTest(products);
            Console.WriteLine("-----------------");
            WhereAndOrderByTest(products);
            Console.WriteLine("-----------------");
            OrderByTest(products);
            Console.WriteLine("-----------------");
            DtoTest(products);
            Console.WriteLine("-----------------");
            JoinTest(categories, products);

        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         orderby p.UnitPrice
                         select new DTO()
                         {
                             CategoryId = p.CategoryId,
                             CategoryName = c.CategoryName,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice,
                         };
            foreach (DTO item in result)
            {   //New Impression
                Console.WriteLine("{0}-------{1}---------{2}----------{3}", item.ProductName, item.CategoryName, item.UnitPrice, item.CategoryId);
            }
        }

        private static void DtoTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice < 6300
                         orderby p.UnitPrice
                         select new DTO() { UnitPrice = p.UnitPrice, CategoryId = p.CategoryId, ProductName = p.ProductName, };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName + " " + item.UnitPrice);
            }
        }

        private static void OrderByTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice < 6500
                         orderby p.UnitPrice
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName + " " + item.UnitPrice);
            }
        }

        private static void WhereAndOrderByTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Phone")).OrderByDescending(p => p.UnitPrice);
            foreach (Product p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Leptop"));
            Console.WriteLine(result);
        }

        private static void AnyTest(List<Product> products)
        {
            bool result = products.Any(product => product.ProductName == "Acer Leptop");
            Console.WriteLine("The Any Test's result is: " + result);
        }

        private static void FindTest(List<Product> products, Product product)
        {
            var result = products.Find(p => p.ProductId == product.ProductId);
            Console.WriteLine(" Its Id: " + result.ProductId);
        }

    }

    public class DTO //Data Transformation Object
    {
        public int UnitPrice { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }


}
