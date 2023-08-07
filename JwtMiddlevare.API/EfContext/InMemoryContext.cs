using JwtMiddlevare.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtMiddlevare.API.EfContext
{
    public class InMemoryContext : DbContext
    {
        private InMemoryContext()
        {

        }
        private static InMemoryContext? instance;
        public static InMemoryContext Singleton
        {
            get
            {
                if (instance == null)
                    instance = new InMemoryContext();
                return instance;
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("UserDb");
        }
        public DbSet<UserModel> Users { get; set; }
    }
}
