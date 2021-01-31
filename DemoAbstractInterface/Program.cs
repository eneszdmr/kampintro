using DemoAbstractInterface.Abstract;
using DemoAbstractInterface.Concrete;
using System;

namespace DemoAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager();
            baseCustomerManager.SaveToDb(new Customer 
            { Id = 1, FirstName = "Enes", LastName = "demir", NationId = "12345678" });

            Customer customer1 = new Customer() {
            Id=1,
            FirstName="engin",
            LastName="demiroğ",NationId="111111111"
            };

           // baseCustomerManager.SaveToDb(customer1);

            BaseCustomerManager baseCustomerManager1 = new KahveDunyasiCustomerManager();
            baseCustomerManager1.SaveToDb(customer1);
            
        }
    }
}
