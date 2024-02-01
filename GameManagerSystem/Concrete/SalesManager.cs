using GameManagerSystem.Abstract;
using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Concrete
{
    public class SalesManager :BaseSalesManager
    {
        public override void Save(Gamer gamer)
        {
            base.Save(gamer);
        }
        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);
        }
        public override void Update(Gamer gamer)
        {
            base.Update(gamer);
        }
    }
}

//public void Delete(Gamer gamer)
//{
//    Console.WriteLine("Satış silindi.");
//}

//public void Save(Gamer gamer)
//{
//    Console.WriteLine("Satış kaydedildi.");
//}

//public void Update(Gamer gamer)
//{
//    Console.WriteLine("Satış güncellendi.");
//}