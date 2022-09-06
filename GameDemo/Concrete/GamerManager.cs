using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GamerManager : IGamerService
    {

        ICheckService _checkService;

        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public void Register(Gamer gamer)
        {
            if (_checkService.Check(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi");
        }

    }
}
