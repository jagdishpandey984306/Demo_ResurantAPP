using Resturant.Shared.Customer;
using Resturant.Shared.ViewModel.Customer;
using ResturantApp.Common;
using System.Collections.Generic;

namespace Resturant.Repository.Customer
{
   public interface ICustomerRepository
    {
        ResponseDetails AddCustomerDetails(CustomerDetails customerDetails, string storedProcedureName);
        List<CustomerViewModel> GetCustomerList(CommonDetails commonDetails, string storedProcedureName);
    }
}
