using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP3
{
    internal class CarCreditManager : ICreditManager
    {
        public void calculate()
        {
            Console.WriteLine("Car Credit calculated");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }


}
