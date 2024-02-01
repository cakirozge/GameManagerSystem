using GameManagerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Entities
{
    public class Campaign: IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int CampaignDiscount { get; set; }
        public string CampaignDescription { get; set; }

    }
}
