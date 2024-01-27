using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Abstract
{
     public interface IUserService
    {
        public void UpdateInformation(User inSystem, User afterUpdate);
        public void SignIn(User user, IUserCheckService userCheckService);
        public void DeleteUser(User user);

    }


}
