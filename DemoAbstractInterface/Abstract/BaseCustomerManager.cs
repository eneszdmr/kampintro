using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstractInterface.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void SaveToDb(Customer customer)
        {
            Console.WriteLine("Saved to Database for :"+customer.FirstName);
        }
    }
}
