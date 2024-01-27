using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Abstract
{
    public interface IUserCheckService
    {
        bool IsRealPerson(User user);

    }

}
