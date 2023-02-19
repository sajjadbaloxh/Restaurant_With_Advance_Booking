using Microsoft.EntityFrameworkCore;
using Restaurant_Advance_Booking.Models;
using RestaurantAdvanceBooking.Models;

namespace Restaurant_Advance_Booking.Data
{
    public class ResturantDbContext: DbContext
    {

        public ResturantDbContext(DbContextOptions<ResturantDbContext> options)
           : base(options)
        {

        }
        // all entities from database as dbsets
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Table_Reservation> Table_Reservations { get; set; }
    }
}
