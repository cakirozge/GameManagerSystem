using GameManagerSystem.Abstract;
using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Concrete
{
    public class CampaignManager : BaseCampaignManager
    {
        public override void Add(Campaign campaign)
        {
            base.Add(campaign);
        }

        public override void Delete(Campaign campaign)
        {
            base.Delete(campaign);
        }
        public override void Update(Campaign campaign)
        {
            base.Update(campaign);
        }
    }
}
