using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP2
{
    //Business classes 
    internal class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Customer added. CustomerNo:  " + customer.CustomerNo);
        }


    }


}
