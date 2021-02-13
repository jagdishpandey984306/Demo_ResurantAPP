

using ResturantApp.Common;

namespace Resturant.Shared.Customer
{
   public class CustomerDetails: CommonDetails
    {
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string TemporaryAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string EmailAddress { get; set; }
    }
}
