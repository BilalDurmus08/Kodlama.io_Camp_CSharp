using Day4_HW_CafeProject.Abstract;
using Day4_HW_CafeProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_CafeProject.Adapters
{
    internal class MernisCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {// I couldn't create mernis validation. When i learn this I will add to my project. For now it will be empty.
            return true;
        }
    }
}
