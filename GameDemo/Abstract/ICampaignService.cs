using GameDemo.Entities;
using System;

namespace GameDemo
{
    internal interface ICampaignService
    {
        void Save(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}