using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class UserCheckManager : ICheckService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.DateOfBirth==1998 && gamer.FirstName=="Taha" && gamer.Id==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
