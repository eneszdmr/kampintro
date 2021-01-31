using DemoAbstractInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstractInterface.Concrete
{
    public class KahveDunyasiCustomerManager : BaseCustomerManager

    {
        private ICustomerCheckService _customerCheckService;

        public KahveDunyasiCustomerManager()
        {
        }

        public KahveDunyasiCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void SaveToDb(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.SaveToDb(customer);
            }
            else
            {
                throw new Exception("not a valid person that you entered");
            }
            
        }

   
    }
}
