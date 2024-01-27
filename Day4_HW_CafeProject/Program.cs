using Day4_HW_CafeProject.Abstract;
using Day4_HW_CafeProject.Adapters;
using Day4_HW_CafeProject.Concrete;
using Day4_HW_CafeProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_CafeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisCheckManager());
            Customer customer = new Customer() {FisrtName = "Bilal", LastName = "Durmuş", DateOfBirth = new DateTime(2003, 2, 1), NationalityId = "20005400124", Id = 123};

            customerManager1.Save(customer);


        }

    }

}
