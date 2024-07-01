using Microsoft.EntityFrameworkCore;
using Web_api.Models;

namespace Web_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Device> cd { get; set; }
    }
}
