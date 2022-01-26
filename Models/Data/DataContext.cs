using Microsoft.EntityFrameworkCore;

namespace Docs.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hoteles> hoteles { get; set; }
    }
}