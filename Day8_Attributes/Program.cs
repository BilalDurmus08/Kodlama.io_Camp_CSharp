using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Attributes
{
    public class Program
    {
        static void Main(string[] args)
        {
             Customer customer = new Customer() { Name = "Bilocan", Id = 258, Age = 33};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);


        }

    }

    [ToTable("Customers")]
    public class Customer
    {
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]
        public int Id { get; set; }
        public int Age { get; set; }
    }

    public class CustomerDal
    {
        [Obsolete]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2}", customer.Name, customer.Id, customer.Age);
        }
        
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2}", customer.Name, customer.Id, customer.Age);
        }

    }
    
    //Attribute targets allow us to where do you use that attribute
    //AllowMultiple allow us to make usanable twice in same object. Like in toTable attribute we can assign more than one attribute name.
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute 
    { 
    
    }

    class ToTableAttribute : Attribute 
    {
        string _NameAttribute;
        public ToTableAttribute(string name)
        {
            _NameAttribute = name;
        }
    }


}
