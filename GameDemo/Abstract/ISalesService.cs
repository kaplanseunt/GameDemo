using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    internal interface ISalesService
    {
        void Sales(Game game, Gamer gamer, Campaign campaign);
    }
}
