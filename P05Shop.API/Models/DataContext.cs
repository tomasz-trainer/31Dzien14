using Microsoft.EntityFrameworkCore;
using P06Shop.Shared;

namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string here
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MySuperShop;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p=>p.Title)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}