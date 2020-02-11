using cars.Models;
using Microsoft.EntityFrameworkCore;

namespace cars.Data
{
    public class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}