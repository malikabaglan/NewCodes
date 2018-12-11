using System;
using System.Collections.Generic;
using TestApp.Models;
using TestApp.Services;

namespace TestApp.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        public MainViewModel()
        {
            var service = new CustomerServices();
            CustomerList = service.GetCustomers();
        }


        private List<Customer> customerList;
        public List<Customer> CustomerList
        {
            get { return customerList; }
            set { SetProperty(ref customerList, value); }
        }

    }
}
