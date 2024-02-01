using GameManagerSystem.Abstract;
using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public override void Save(Gamer gamer)
        {
            if ( _validationService.CheckIfRealPerson(gamer))  // puan verdiği için gerçek kişi doğrulaması yapıyor.
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid person."); //false dönerse
            }
        }

        public override void Update(Gamer gamer)
        {
            base.Update(gamer);

        }

        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);

        }
    }
}
