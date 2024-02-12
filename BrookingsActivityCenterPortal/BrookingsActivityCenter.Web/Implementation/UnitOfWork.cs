using BrookingsActivityCenter.Web.Data.Context;
using BrookingsActivityCenter.Web.Repository;

namespace BrookingsActivityCenter.Web.Implementation
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICustomerRepository CustomerRepository { get; private set; }

        public IReservationRepository ReservationRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CustomerRepository = new CustomerRepository(_context);
            ReservationRepository = new ReservationRepository(_context);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
