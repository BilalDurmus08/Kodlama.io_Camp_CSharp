using Day4_HW_GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Day4_HW_GameProject.Entities;


namespace Day4_HW_GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            Game game1 = new Game { GameName = "LeagueOfLegends", Price = 120 };
            Game game2 = new Game { GameName = "Stick Fight", Price = 50 };
            gameManager.AddGame(game1);
            gameManager.AddGame(game2);
            User user1 = new User { DateOfBirth = new DateTime(2003, 2, 1), FisrtName = "Bilal", LastName = "Durmus", NationalityId = "123456789" };
            User user2 = new User { DateOfBirth = new DateTime(2004, 5, 7), FisrtName = "Yasin", LastName = "Kurtulus", NationalityId = "987654321" };
            UserManager userManager = new UserManager();
            userManager.SignIn(user1, new UserCheckManager());
            userManager.SignIn(user2, new UserCheckManager());
            Campaign campaign1 = new Campaign() { CampaignName = "Be Happy", DiscountPercent = 10};
            gameManager.SellingGame(game2, user2, campaign1);
            

        }

    }

}
