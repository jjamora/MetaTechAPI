using Microsoft.EntityFrameworkCore;
using MTC.Core.Models;

namespace MTC.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Add Tables to Database
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> OrderDetails { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Pizza_Type> Pizza_Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
