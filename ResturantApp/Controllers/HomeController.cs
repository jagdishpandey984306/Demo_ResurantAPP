using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resturant.Business.Customer;
using Resturant.Shared.Common;
using Resturant.Shared.Customer;
using ResturantApp.Common;
using ResturantApp.Extensions;
using ResturantApp.Models;

namespace ResturantApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerBuisness _customerBuisness;
        public HomeController(ICustomerBuisness customerBuisness)
        {
            _customerBuisness = customerBuisness;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddDetails(CustomerDetails customerDetails)
        {
            customerDetails.Flag = "AddCustomer";
            customerDetails.User = "Admin";
            var result = _customerBuisness.AddCustomerDetails(customerDetails);
            return RedirectToAction("Index").WithAlertMessage(ResponseConstant.SuccessCode, result.Message);
        }
        public IActionResult CustomerList()
        {
            CommonDetails commonDetails = new CommonDetails
            {
                Flag = "CustomerList",
                User = "Admin"
            };
            var result = _customerBuisness.GetCustomerList(commonDetails);
            return View(result);
        }
    }
}
