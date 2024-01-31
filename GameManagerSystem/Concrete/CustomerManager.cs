using GameManagerSystem.Abstract;
using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Concrete
{
    public class CustomerManager:BaseCustomerManager
    {
        IValidationCheckService _validationCheckService;

        public CustomerManager(IValidationCheckService validationCheckService)
        {
            _validationCheckService = validationCheckService;   
        }

        public override void Save(Customer customer)
        {
            if (_validationCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Doğrulama yapılamadı." + customer.FirstName);
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
