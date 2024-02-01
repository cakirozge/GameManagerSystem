using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(  "Silinme işlemi başarılı.");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Kaydedilme işlemi başarılı.");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Güncelleme işlemi başarılı.");
        }
    }
}
