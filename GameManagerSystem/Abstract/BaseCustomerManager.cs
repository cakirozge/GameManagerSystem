using GameManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Eklendi.");
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Silindi.");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Güncellendi.");
        }
    }
}
