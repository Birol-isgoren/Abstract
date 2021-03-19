using CoffeShops.Abstract;
using CoffeShops.Adapters;
using CoffeShops.Concrete;
using CoffeShops.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShops
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServicesAdapter());
            customerManager.Save(new Customer { FirstName= "Birol", LastName ="işgören", NationaltyId = "12345678901", DateOfBirth = new DateTime(1902,11,13)});
            BaseCustomerManager cust = new NeroCustomerManager();
            Console.ReadLine();
        }

    }
}
