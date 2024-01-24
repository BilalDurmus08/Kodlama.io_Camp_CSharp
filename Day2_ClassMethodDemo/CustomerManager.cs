using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ClassMethodDemo
{
    internal class CustomerManager
    {
        public static List<Customer> Customers = new List<Customer>(); 
        static void Main(string[] args)
            {
                Customer customer1 = new Customer();
                customer1.Name = "Bilal";
                customer1.Age = 20;
                customer1.id = 202020;

                Customer customer2 = new Customer();
                customer2.Name = "Yasin";
                customer2.Age = 19;
                customer2.id = 18942;

                AddCustomer(customer1);
                AddCustomer(customer2);
                BringCustomers();   

        }

        public static void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            Console.WriteLine(customer.Name + " Added to the Company");
        }

        public static void RemoveCustomer(Customer customer)
        {
          if (Customers.Contains(customer))
            {
                Console.WriteLine("Customer removed");
                Customers.Remove(customer);
            }
            else
            {
                Console.WriteLine("Customer do not exist");
            }
        }

        public static void BringCustomers() {
            if (Customers.Count != 0)
            {
                foreach(Customer customer1 in Customers)
                {
                    Console.WriteLine(customer1.Name);
                    Console.WriteLine(customer1.Age);
                    Console.WriteLine(customer1.id);
                    Console.WriteLine("--------------");
                } 
            
            }
            else
            {
                Console.WriteLine("Customer do not exist");
            }

        }

    }

}
