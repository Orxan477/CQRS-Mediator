using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Test> Tests{ get; set; }
        public DbSet<Human> Humans{ get; set; }
    }
}
