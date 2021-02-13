

using Resturant.Repository.Dapper;
using Resturant.Shared.Customer;
using Resturant.Shared.ViewModel.Customer;
using ResturantApp.Common;
using System.Collections.Generic;
using System.Linq;

namespace Resturant.Repository.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDapperDao _dapperDao;
        public CustomerRepository(IDapperDao dapperDao)
        {
            _dapperDao = dapperDao;
        }

        public ResponseDetails AddCustomerDetails(CustomerDetails customerDetails, string storedProcedureName)
        {
            var response = _dapperDao.ExecuteQuery<ResponseDetails>(storedProcedureName, customerDetails).FirstOrDefault();
            return response;
        }

        public List<CustomerViewModel> GetCustomerList(CommonDetails commonDetails, string storedProcedureName)
        {
            var response = _dapperDao.ExecuteQuery<CustomerViewModel>(storedProcedureName, commonDetails);
            return response;
        }
    }
}
