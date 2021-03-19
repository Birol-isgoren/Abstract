using CoffeShops.Abstract;
using CoffeShops.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShops.Adapters
{
    public class MernisServicesAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Entities.Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(long.Parse(customer.NationaltyId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
