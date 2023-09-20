using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Explorer> Explorer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new Category { id = 3, Name = "History", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Explorer>().HasData(
                new Explorer { Id = 1, Name = "Action" },
                new Explorer { Id = 2, Name = "Sci-Fi"},
                new Explorer { Id = 3, Name = "History" }
                );
        }
        
        
    }
}
