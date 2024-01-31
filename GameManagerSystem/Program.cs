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
            BaseCustomerManager customerManager = new SalesManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { Id=1, FirstName="Özge", LastName="Çakır", BirthTimeYear = new DateTime(1995, 8, 15), NationalityId="-------------------"});
            



        }
    }
}