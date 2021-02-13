using Resturant.Shared.Customer;
using Resturant.Shared.ViewModel.Customer;
using ResturantApp.Common;
using System.Collections.Generic;

namespace Resturant.Business.Customer
{
   public  interface ICustomerBuisness
    {
        ResponseDetails AddCustomerDetails(CustomerDetails customerDetails);
        List<CustomerViewModel> GetCustomerList(CommonDetails commonDetails);
    }
}
