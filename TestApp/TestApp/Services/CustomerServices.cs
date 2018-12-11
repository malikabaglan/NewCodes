using System;
using System.Collections.Generic;
using TestApp.Models;

namespace TestApp.Services
{
    public class CustomerServices
    {
        public CustomerServices()
        {
        }


        public List<Customer> GetCustomers()
        {
            var list = new List<Customer>

            {

                new Customer
                {
                    FirstName="Ilon",
                    LastName="Mask",

                    Location="USA"


                },
                 new Customer
                {
                    FirstName="Mark",
                    LastName="Zuckerberg"


                },
                  new Customer
                {
                    FirstName="Jeff",
                    LastName="Bezos"


                },
                   new Customer
                {
                    FirstName="Patrick",
                    LastName="Collision"


                },
                    new Customer
                {
                    FirstName="Brew",
                    LastName="Houston"


                },
            };
            return list;
        }
    }
}
