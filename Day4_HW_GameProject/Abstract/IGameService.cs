using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Abstract
{
    internal interface IGameService
    {
        void AddGame(Game game);
        void RemoveGame(Game game);
        void SellingGame(Game game, User user);
        void SellingGame(Game game, User user, Campaign campaign);
    }

}
