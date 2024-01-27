using Day4_HW_GameProject.Abstract;
using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Concrete
{
    internal class UserCheckManager : IUserCheckService
    { //Just Imagine I connect E-devlet and made validation. Okayy ??!!
        public bool IsRealPerson(User user)
        {   
            return true;
        }
    }

}
