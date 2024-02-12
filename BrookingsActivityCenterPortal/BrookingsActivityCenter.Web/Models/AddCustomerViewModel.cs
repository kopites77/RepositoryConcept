namespace BrookingsActivityCenter.Web.Models
{
    public class AddCustomerViewModel
    {
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public int CustomerPhone { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
