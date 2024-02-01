using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Abstract
{
    public interface IValidationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
