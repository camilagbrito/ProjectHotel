using HotelProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectHotel.Data
{
    public class ProjectHotelDbContext: DbContext
    {
        public ProjectHotelDbContext(DbContextOptions<ProjectHotelDbContext> options) : base(options) { }

        public DbSet<Room> Room { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
