using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Abstract
{
    public abstract class BaseSalesManager : IGamerService
    {
        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Satış silindi.");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Satış işlemi kaydedildi. " + "Oyun Adı : " + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Satış güncellendi.");
        }
    }
}
