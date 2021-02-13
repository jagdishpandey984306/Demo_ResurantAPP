

using Resturant.Repository.Customer;
using Resturant.Shared.Customer;
using Resturant.Shared.ViewModel.Customer;
using ResturantApp.Common;
using System.Collections.Generic;

namespace Resturant.Business.Customer
{
   
    public class CustomerBusiness : ICustomerBuisness
    {
        private readonly ICustomerRepository _customerRepository;
        private const string StoredProcedureName = "PROC_Customers";
        public CustomerBusiness(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        
        public ResponseDetails AddCustomerDetails(CustomerDetails customerDetails)
        {
            return _customerRepository.AddCustomerDetails(customerDetails, StoredProcedureName);
        }

        public List<CustomerViewModel> GetCustomerList(CommonDetails commonDetails)
        {
            return _customerRepository.GetCustomerList(commonDetails, StoredProcedureName);
        }
    }
}
