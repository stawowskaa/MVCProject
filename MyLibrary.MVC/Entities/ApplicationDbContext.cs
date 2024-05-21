using Microsoft.EntityFrameworkCore;

namespace MyLibrary.MVC.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MyLibraryEntity> MyLibrary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyLibraryMVC;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
