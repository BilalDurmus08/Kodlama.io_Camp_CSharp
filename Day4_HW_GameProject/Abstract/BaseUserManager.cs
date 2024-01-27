using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void DeleteUser(User user)
        {
            Console.WriteLine("User Deleted");
        }
        public virtual void SignIn(User user, IUserCheckService userCheckService)
        {
        }

        public void UpdateInformation(User inSystem, User afterUpdate)
        {
            inSystem.FisrtName = afterUpdate.FisrtName;
            inSystem.LastName = afterUpdate.LastName;
            inSystem.DateOfBirth = afterUpdate.DateOfBirth;
            inSystem.NationalityId = afterUpdate.NationalityId;
            Console.WriteLine("User update process is done");
        }

    }

}
