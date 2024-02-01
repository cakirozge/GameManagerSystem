using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi." + "Kampanya Adı: " + campaign.CampaignName);
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
