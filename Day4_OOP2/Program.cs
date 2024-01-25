using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Individual individual = new Individual();
            individual.Name = "Bilal";
            individual.Surname = "Durmus";
            individual.Id = 4;
                
            Corporate corporate = new Corporate();
            corporate.Id = 5;
            corporate.CompanyNo = "Aselsan";
            corporate.TaxNo = "68487";
            corporate.CustomerNo = "487897";

            //We can create with both way. We created referrance of Corporate and Individual.
            Customer customer = new Corporate();
            Customer customer2 = new Individual();

        }

    }


}
