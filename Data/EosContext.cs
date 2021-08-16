using Microsoft.EntityFrameworkCore;
using Eos.Models;

namespace Eos.Data
{
    public class EosContext : DbContext
    {
        public EosContext(DbContextOptions<EosContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("UserEos");
            modelBuilder.Entity<Post>().ToTable("PostEos");
        }
    }
}
