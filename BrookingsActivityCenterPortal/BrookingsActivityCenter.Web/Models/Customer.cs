namespace BrookingsActivityCenter.Web.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public int CustomerPhone { get; set; }
        public string Address { get; set; } = string.Empty;
        public List<Reservation>? Reservations { get; set; }
    }
}
