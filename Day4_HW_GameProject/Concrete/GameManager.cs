using Day4_HW_GameProject.Abstract;
using Day4_HW_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW_GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void AddGame(Game game)
        {
            games.Add(game);
            Console.WriteLine("Game have been added");
        }

        public void RemoveGame(Game game)
        {
            if (games.Contains(game))
            {
                games.Remove(game);
                Console.WriteLine("Game have been removed");
            }
            else
            {
                Console.WriteLine("Game do not exist");
            }
        }

        public void SellingGame(Game game, User user)
        {
            Console.WriteLine("This game " + game.GameName + " have selled to this guy: " + user.FisrtName + " " + user.LastName + 
                ". The price is: " + game.Price);
        }

        public void SellingGame(Game game, User user, Campaign campaign)
        {
            double afterCampaing = game.Price - game.Price / campaign.DiscountPercent;
            Console.WriteLine("This game " + game.GameName + " with campaign name: " + campaign.CampaignName 
                + " have selled to this guy: " + user.FisrtName + " " + user.LastName +
                ". with the campaign price is: " + afterCampaing);
        }
    }


}
