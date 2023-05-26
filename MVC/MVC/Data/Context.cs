using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors>? Authors { get; set; }
        public DbSet<Publisher>? Publishers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasKey(p => p.ID_Book);
            modelBuilder.Entity<Books>().ToTable("Books");
            modelBuilder.Entity<Authors>().HasKey(p => p.ID_Author);
            modelBuilder.Entity<Authors>().ToTable("Authors");
            modelBuilder.Entity<Publisher>().HasKey(p => p.ID_Publisher);
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
        }
    }
}