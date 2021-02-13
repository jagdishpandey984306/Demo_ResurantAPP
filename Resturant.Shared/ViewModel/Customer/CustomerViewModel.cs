using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant.Shared.ViewModel.Customer
{
   public class CustomerViewModel
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string TemporaryAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string EmailAddress { get; set; }
    }
}
