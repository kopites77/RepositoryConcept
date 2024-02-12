using BrookingsActivityCenter.Web.Data.Context;
using BrookingsActivityCenter.Web.Models;
using BrookingsActivityCenter.Web.Repository;

namespace BrookingsActivityCenter.Web.Implementation
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
