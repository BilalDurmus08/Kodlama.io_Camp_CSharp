using Day4_HW_GameProject.Abstract;
using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Concrete
{
    internal class UserManager : BaseUserManager
    {
        List<User> users = new List<User>();
        public override void DeleteUser(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
                base.DeleteUser(user);
            }
            else
            {
                Console.WriteLine("User Do not contain with this user " + user.FisrtName);
            }
            
        }

        public override void SignIn(User user, IUserCheckService userCheckService)
        {
            if (userCheckService.IsRealPerson(user))
            {
                users.Add(user);
                Console.WriteLine("Validation is correct.");
            }
            else
            {
                throw new Exception("User is not valid");
            }
        }

    }


}
