using Microsoft.EntityFrameworkCore;

namespace JwtMiddleware.API.Context
{
    public class RandomContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("UsersDb");
        }

        public DbSet<MyUsers> Users { get; set; }
    }
}
