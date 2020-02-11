using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Lab2Phase1.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } //Creates a set of DB entities that uses Car

        //Constructor
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=sql.neit.edu\\studentsqlserver,4500;Database=SE407_LWarner;User Id=SE407_LWarner;Password=008002738;");
    }
    
}
