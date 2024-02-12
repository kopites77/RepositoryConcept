namespace BrookingsActivityCenter.Web.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
}
