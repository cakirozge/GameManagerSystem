using GameManagerSystem.Abstract;
using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Concrete
{
    public class SalesManager:BaseCustomerManager
    {
        IValidationCheckService _validationCheckService;

        public SalesManager(IValidationCheckService validationCheckService)
        {
            _validationCheckService = validationCheckService;
        }
        public override void Save(Game game)
        {

            if (_validationCheckService.CheckIfRealPerson(game))
            {
                base.Save(game);
            }
            else
            {
                throw new Exception("Doğrulama yapılamadı.");
            }
        }

        public override void Update(Customer customer)
        {
            if (_validationCheckService.CheckIfRealPerson(customer))
            {
                base.Update(customer);
            }
            else
            {
                throw new Exception("Güncelleme yapılamadı." + customer.FirstName);
            }

        }

        public override void Delete(Customer customer)
        {
            if (_validationCheckService.CheckIfRealPerson(customer))
            {
                base.Delete(customer);
            }
            else
            {
                throw new Exception("Silinme işlemi yapılamadı" + customer.FirstName);
            }

        }
    }
}
