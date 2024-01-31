using GameManagerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Entities
{
    public class Campaign:IEntity
    {
        public string FirstName { get; set; }
        public int DiscountRate { get; set; }
    }
}
