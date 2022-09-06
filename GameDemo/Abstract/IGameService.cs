using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGameService
    {
        void Save(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
