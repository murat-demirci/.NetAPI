using InMemory.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemory.API.Context
{
    public class InMemoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("StudentPortalDb");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
