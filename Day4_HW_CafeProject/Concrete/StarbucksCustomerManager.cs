using Day4_HW_CafeProject.Abstract;
using Day4_HW_CafeProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_CafeProject.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }
          
        public override void Save(Customer customer)
        {
            if (customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("This is not a valid person");
            }

        }
    }

}
