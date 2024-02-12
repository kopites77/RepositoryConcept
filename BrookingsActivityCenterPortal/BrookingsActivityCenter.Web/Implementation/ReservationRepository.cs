using BrookingsActivityCenter.Web.Data.Context;
using BrookingsActivityCenter.Web.Models;
using BrookingsActivityCenter.Web.Repository;

namespace BrookingsActivityCenter.Web.Implementation
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
