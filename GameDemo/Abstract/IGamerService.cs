using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGamerService
    {
        void Register(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
