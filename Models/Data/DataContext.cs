using Microsoft.EntityFrameworkCore;

namespace Docs.Models.Data
{
    public class DataContext : DbContext
    {
        
        public DbSet<Hoteles> hoteles { get; set; }
    }
}