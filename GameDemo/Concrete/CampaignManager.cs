using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted");
        }

        public void Save(Campaign campaign)
        {

        }

        public void Update(Campaign campaign)
        {

            Console.WriteLine("Campaign Updated");
        }




        internal void Save(string campaignName)
        {
            Console.WriteLine("Campaign Added");
        }

        internal void Delete(string campaignName)
        {

            Console.WriteLine("Campaign Deleted");
        }
    }
}

