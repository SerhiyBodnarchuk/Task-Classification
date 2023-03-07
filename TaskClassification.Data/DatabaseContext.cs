using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskClassification.Data.Entities;

namespace TaskClassification.Data
{
    public class DatabaseContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TeamUser> TeamUsers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
