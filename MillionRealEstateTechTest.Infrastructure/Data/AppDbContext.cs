using Microsoft.EntityFrameworkCore;
using MillionRealEstateTechTest.Application.Entities;

namespace MillionRealEstateTechTest.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}
