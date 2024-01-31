using GameManagerSystem.Abstract;
using GameManagerSystem.Entities;
using MernisServiceReferens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Adapters
{
    public class MernisServiceAdapter : IValidationCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
               customer.BirthTimeYear.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
