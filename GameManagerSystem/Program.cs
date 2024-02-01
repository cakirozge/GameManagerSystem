
using GameManagerSystem.Abstract;
using GameManagerSystem.Adapters;
using GameManagerSystem.Concrete;
using System;

namespace GameManagerSystem
{
    class Program
    {
        static void Main(string[] args) 
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(new Entities.Gamer { BirthDayYear = new DateTime(1995, 8, 15), FirstName = "Özge", LastName = "Çakır", Id = 1, NationalityId = "Kendi TC Kimlik No giriniz" });
            //Console.ReadLine();

            BaseSalesManager salesManager = new SalesManager();
            salesManager.Save(new Entities.Gamer { FirstName = "Mario ", LastName = "Çakır" });

            BaseCampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Entities.Campaign {CampaignName= "Yılbaşı Kampanyası" });


        }
    }
}