using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game() {GameName="FIFA2023",PriceOfGame=250,Id=01 };

            //Campaign campaign = new Campaign() { CampaignName="Discount1"};



            GamerManager gamerManager = new GamerManager(new UserCheckManager()) { };
            gamerManager.Register(new Gamer
            {
                FirstName = "Taha",
                LastName = "Kaplan",
                DateOfBirth = 1998,
                Id = 12345
            }
                ); 

            //GameManager gameManager = new GameManager();
            //gameManager.Save(game.GameName);





            //CampaignManager campaignManager = new CampaignManager();
            //campaignManager.Save(campaign.CampaignName);
            //campaignManager.Delete(campaign.CampaignName);



        }

        
    }
}
