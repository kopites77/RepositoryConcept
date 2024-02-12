using BrookingsActivityCenter.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BrookingsActivityCenter.Web.Data.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
