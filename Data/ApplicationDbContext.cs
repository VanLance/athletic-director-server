using Athletic_Director.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Athletic_Director.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set;}
    }
}
