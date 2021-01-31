using DemoAbstractInterface.Abstract;
using System;

namespace DemoAbstractInterface
{
    public class Customer:IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationId { get; set; }
    }
}
